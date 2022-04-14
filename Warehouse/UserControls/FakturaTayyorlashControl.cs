using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.API.APIServices;
using Warehouse.CRUDForms;
using Warehouse.UI_Services;
using Warehouse.ViewModels;

namespace Warehouse.UserControls
{
    public partial class FakturaTayyorlashControl : UserControl
    {
        public List<ProductStorageModel> ProductList = new List<ProductStorageModel>();
        public List<FakturaItemCreateResponse> FakturaList = new List<FakturaItemCreateResponse>();
        FakturaItemService fakturaItemService = new FakturaItemService();
        List<FakturaItemViewModel> fakturaItemViews = new List<FakturaItemViewModel>();
        FakturaService fakturaService = new FakturaService();
        WaitFormFunc waitForm = new WaitFormFunc();
        List<FakturaItemModel> _fakturaItemModels = new List<FakturaItemModel>();
        List<FakturaCreateResponse> _fakturaModels = new List<FakturaCreateResponse>();
        int i = 1 ;
        FakturaItemCreateResponse createResponse { get; set; }
        public FakturaTayyorlashControl()
        {
            InitializeComponent();
            searchType_comboBox.SelectedIndex = 0;

        }

        public void FillDataGrid(FakturaItemViewModel fakturaItemView)
        {
            searchDataGrid.Visible = false;
            FakturaItemModel faktura = new FakturaItemModel()
            {
                FakturaId = Form1.Faktura.Id,
                ProductId = fakturaItemView.Id,
                BodyDollar = fakturaItemView.Body_dollar,
                Dollar = fakturaItemView.Dollar,
                Quantity = fakturaItemView.Quantity,
            };
            FakturaItemViewModel viewModel = new FakturaItemViewModel()
            {
                index = i++,
                ProdName = fakturaItemView.ProdName,
                ProdBarcode = fakturaItemView.ProdBarcode,
                ProdGroup = fakturaItemView.ProdGroup,
                ProdPreparer = fakturaItemView.ProdPreparer,
                Dollar = fakturaItemView.Dollar,
                Body_dollar = fakturaItemView.Body_dollar,
                Quantity = fakturaItemView.Quantity,
                
            };
            _fakturaItemModels.Add(faktura);
            fakturaItemViews.Add(viewModel);

            summaTanNarx_txt.Text = fakturaItemViews.Sum(a => a.Body_dollar).ToString();
            summaSotishNarx_txt.Text = fakturaItemViews.Sum(a => a.Dollar).ToString();

            fakturaDataGrid.DataSource = null;
            fakturaDataGrid.DataSource = fakturaItemViews;
            fakturaDataGrid.Columns["index"].HeaderText = "T/r";
            fakturaDataGrid.Columns["ProdName"].HeaderText = "Mahsulot";
            fakturaDataGrid.Columns["ProdPreparer"].HeaderText = "Preparer";
            fakturaDataGrid.Columns["ProdGroup"].HeaderText = "Guruh";
            fakturaDataGrid.Columns["ProdBarcode"].HeaderText = "Shtrix kod";
            fakturaDataGrid.Columns["Body_dollar"].HeaderText = "Tan narxi $";
            fakturaDataGrid.Columns["Dollar"].HeaderText = "Sotish narxi $";
            fakturaDataGrid.Columns["Quantity"].HeaderText = "Soni";
            
            fakturaDataGrid.Refresh();
        }

        private void searchDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            searchDataGrid.Visible = false;
            if (e.KeyCode == Keys.Enter)
            {
                ProductStorageModel storageModel = Form1.Products.Where(a => a.Barcode == (searchDataGrid.SelectedCells[4].Value.ToString()) && a.Quantity== double.Parse(searchDataGrid.SelectedCells[7].Value.ToString())).FirstOrDefault();
                KorzinkaPage korzinkaPage = new KorzinkaPage();
                korzinkaPage.FillKorzinka(this, storageModel);
                korzinkaPage.ShowDialog();
            }
        }

        private void comboFilial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FakturaTayyorlashControl_Load(object sender, EventArgs e)
        {
            foreach (var item in Form1.Filials)
            {
                comboFilial.Items.Add(item.Name);
            }
        }

        private async void create_btn_Click(object sender, EventArgs e)
        {
            if(comboFilial.SelectedItem == null)
            {
                MessageBox.Show("Iltimos filialni tanlang", "Xatolik!", MessageBoxButtons.OK);
                return;
            }
            FakturaCreateModel fakturaCreate = new FakturaCreateModel()
            {
                Filial = Form1.Filials.Find(a => a.Name.Contains(comboFilial.SelectedItem.ToString())).Id,
                Status = 0
            };
            waitForm.Show();
            FakturaCreateResponse response = await fakturaService.CreateFaktura(fakturaCreate);
            _fakturaModels.Add(response);
            Form1.Faktura = response;
            waitForm.Close();
        }

        private async void send_btn_Click(object sender, EventArgs e)
        {
            waitForm.Show();
            await fakturaService.ConfirmFaktura(Form1.Faktura.Id, "1");
            foreach (var item in _fakturaItemModels)
            {
                FakturaItemCreateResponse response = await fakturaItemService.CreateFakturaItem(item);
                
            }
            fakturaDataGrid.DataSource = null;
            Form1.Faktura = null;
            _fakturaItemModels.Clear();
            fakturaItemViews.Clear();
            waitForm.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            
            savedFakturaDataGrid.DataSource = _fakturaModels;
            savedFakturaDataGrid.Columns["Id"].Visible = false;
            savedFakturaDataGrid.Columns["Filial"].HeaderText = "Filial";
            savedFakturaDataGrid.Columns["Date"].HeaderText = "Sana";
            savedFakturaDataGrid.Columns["Status"].HeaderText = "status";

            SavedFakturaItemDataGrid.DataSource = fakturaItemViews;
            SavedFakturaItemDataGrid.Columns["index"].HeaderText = "T/r";
            SavedFakturaItemDataGrid.Columns["ProdName"].HeaderText = "Mahsulot";
            SavedFakturaItemDataGrid.Columns["ProdBarcode"].HeaderText = "Shtrix kod";
            SavedFakturaItemDataGrid.Columns["ProdGroup"].HeaderText = "Guruh";
            SavedFakturaItemDataGrid.Columns["ProdPreparer"].HeaderText = "Preparer";
            SavedFakturaItemDataGrid.Columns["Dollar"].HeaderText = "Sotish narxi $";
            SavedFakturaItemDataGrid.Columns["Body_dollar"].HeaderText = "Tan narxi $";
            SavedFakturaItemDataGrid.Columns["Quantity"].HeaderText = "Soni";
            SavedFakturaItemDataGrid.Refresh();
            tabControl1.SelectedIndex = 1;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string barcode = fakturaDataGrid.SelectedCells[2].Value.ToString();
            FakturaItemViewModel fakturaItem = fakturaItemViews.Where(a => a.ProdBarcode.Contains(barcode)).Last();
            EtidFakturaPage editFaktura = new EtidFakturaPage();
            editFaktura.FillEditForm(this, fakturaItem);
            editFaktura.ShowDialog();
        }

        public void EditDataGridItem(FakturaItemViewModel fakturaItemView)
        {
            //fakturaDataGrid.DataSource = null;

            //FakturaItemModel faktura = new FakturaItemModel()
            //{
            //    FakturaId = Form1.Faktura.Id,
            //    ProductBarcode = fakturaItemView.ProdBarcode,
            //    BodyDollar = fakturaItemView.Body_dollar,
            //    Dollar = fakturaItemView.Dollar,
            //    Quantity = fakturaItemView.Quantity,
            //};
            //FakturaItemViewModel viewModel = new FakturaItemViewModel()
            //{
            //    ProdName = fakturaItemView.ProdName,
            //    ProdBarcode = fakturaItemView.ProdBarcode,
            //    ProdGroup = fakturaItemView.ProdGroup,
            //    ProdPreparer = fakturaItemView.ProdPreparer,
            //    Dollar = fakturaItemView.Dollar,
            //    Body_dollar = fakturaItemView.Body_dollar,
            //    Quantity = fakturaItemView.Quantity,

            //};
            //_fakturaItemModels.Add(faktura);
            //fakturaItemViews.Add(viewModel);
            //fakturaDataGrid.DataSource = fakturaItemViews;
            //fakturaDataGrid.Columns["index"].HeaderText = "T/r";
            //fakturaDataGrid.Columns["ProdName"].HeaderText = "Mahsulot";
            //fakturaDataGrid.Columns["ProdBarcode"].HeaderText = "Shtrix kod";
            //fakturaDataGrid.Columns["ProdGroup"].HeaderText = "Guruh";
            //fakturaDataGrid.Columns["ProdPreparer"].HeaderText = "Preparer";
            //fakturaDataGrid.Columns["Dollar"].HeaderText = "Sotish narxi $";
            //fakturaDataGrid.Columns["Body_dollar"].HeaderText = "Tan narxi $";
            //fakturaDataGrid.Columns["Quantity"].HeaderText = "Soni";

            //fakturaDataGrid.Refresh();
        }

        private void sendSaved_btn_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (Form1.Faktura == null)
            {
                MessageBox.Show("Faktura yaratilmagan, Iltimos avval 'Yaratish' tugmasini bosing!", "Xabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ImportFromExcel import = new ImportFromExcel();
            import.ImportFromExcelData(fakturaDataGrid, this);
            
        }

        private void search_mahsulot_txt_TextChanged(object sender, EventArgs e)
        {
            if(search_mahsulot_txt.Text == "")
            {
                searchDataGrid.Visible = false;
            }
            if (Form1.Faktura == null)
            {
                MessageBox.Show("Faktura yaratilmagan, Iltimos avval 'Yaratish' tugmasini bosing!", "Xabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            searchDataGrid.Visible = true;
            searchDataGrid.DataSource = null;
            if (searchType_comboBox.SelectedIndex == 0)
            {
                ProductList = Form1.Products.Where(a => a.Barcode.Contains(search_mahsulot_txt.Text)).ToList();
                searchDataGrid.DataSource = ProductList;

            }
            else if (searchType_comboBox.SelectedIndex == 1)
            {
                ProductList = Form1.Products.Where(a => a.Name.Contains(search_mahsulot_txt.Text)).ToList();
                searchDataGrid.DataSource = ProductList;
            }
            if (ProductList != null)
            {
                searchDataGrid.Columns["Id"].Visible = false;
                searchDataGrid.Columns["Name"].HeaderText = "Mahsulot nomi";
                searchDataGrid.Columns["Barcode"].HeaderText = "Shrix kodi";
                searchDataGrid.Columns["Preparer"].HeaderText = "Yetkazib beruvchi";
                searchDataGrid.Columns["Group"].HeaderText = "Guruhi";
                searchDataGrid.Columns["Quantity"].HeaderText = "Soni";
            }
        }
    }
}
