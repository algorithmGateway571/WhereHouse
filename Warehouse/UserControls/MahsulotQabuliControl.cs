using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.API.APIServices;
using Warehouse.CRUDForms;
using Warehouse.ViewModels;

namespace Warehouse.UserControls
{
    public partial class MahsulotQabuliControl : UserControl
    {
        ReceiveItemService itemService = new ReceiveItemService();
        List<ProductStorageModel> productStorages = new List<ProductStorageModel>();
        List<ReceiveItemModel> receiveItems = new List<ReceiveItemModel>();
        List<MahsulotQabulViewModel> qabulViewModels = new List<MahsulotQabulViewModel>();
        List<ReceiveItemCreateModel> createModelList = new List<ReceiveItemCreateModel>();
        MahsulotQabulViewModel _qabulViewModel { get; set; }
        ReceiveItemCreateModel createModel { get; set; }
        WaitForm waitForm = new WaitForm();
        int i = 1;
        public MahsulotQabuliControl()
        {
            InitializeComponent();
            searchType_combobox.SelectedIndex = 0;

        }

        public void FillDataGrid(MahsulotQabulViewModel qabulViewModel)
        {
            qabulViewModel.Index = i++;
            _qabulViewModel = qabulViewModel;
            receiveDataGrid.DataSource = null;
            qabulViewModels.Add(qabulViewModel);
            receiveDataGrid.DataSource = qabulViewModels;
            receiveDataGrid.Columns["Index"].HeaderText = "T/r";
            receiveDataGrid.Columns["ProdName"].HeaderText = "Mahsulot";
            receiveDataGrid.Columns["ProdBarcode"].HeaderText = "Shtrix kod";
            receiveDataGrid.Columns["ProdDeliver"].HeaderText = "Yetkazuvchi";
            receiveDataGrid.Columns["ProdGroup"].HeaderText = "Guruh";
            receiveDataGrid.Columns["Dollar"].HeaderText = "Tan narx";
            receiveDataGrid.Columns["SotishDollar"].HeaderText = "Sotish narx";
            receiveDataGrid.Columns["Quantity"].HeaderText = "Soni";

            createModel = new ReceiveItemCreateModel()
            {
                Receive = qabulViewModel.Receiveid,
                Product = qabulViewModel.ProdBarcode,
                Dollar = qabulViewModel.Dollar,
                SotishDollar = qabulViewModel.SotishDollar,
                Quantity = qabulViewModel.Quantity,
            };
            createModelList.Add(createModel);
            summaTanNarx_txt.Text = createModelList.Sum(a => a.Dollar).ToString();
            summaSotish_txt.Text = createModelList.Sum(a => a.SotishDollar).ToString();
            receiveDataGrid.Refresh();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            QabulniYaratishPage qabulniYaratishPage = new QabulniYaratishPage();
            qabulniYaratishPage.ShowDialog();
            btnQabul.Enabled = false;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            if (Form1.ReceiveItemModel.Receive == 0 )
            {
                MessageBox.Show("Кабул бошланмаган, Илтимос аввал 'Кабулни бошлаш' тугмасини босинг!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                YangiMahsulotPage yangiMahsulot = new YangiMahsulotPage();
                yangiMahsulot.SensReceive(this);
                yangiMahsulot.ShowDialog();
            }

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Form1.ReceiveItemModel.Receive == 0 )
            {
                MessageBox.Show("Кабул бошланмаган, Илтимос аввал 'Кабулни бошлаш' тугмасини босинг!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            searchProdDataGrid.Visible = true;
            searchProdDataGrid.DataSource = null;
            if (searchType_combobox.SelectedIndex == 0)
            {
                productStorages = Form1.Products.Where(a => a.Barcode.Contains(search_product_txt.Text)).ToList();
                searchProdDataGrid.DataSource = productStorages;
            }
            else
            {
                productStorages = Form1.Products.Where(a => a.Name.Contains(search_product_txt.Text)).ToList();
                searchProdDataGrid.DataSource = productStorages;
            }
            if (productStorages != null)
            {
                searchProdDataGrid.Columns["Id"].Visible = false;
                searchProdDataGrid.Columns["Name"].HeaderText = "Mahsulot nomi";
                searchProdDataGrid.Columns["Barcode"].HeaderText = "Shrix kodi";
                searchProdDataGrid.Columns["Preparer"].HeaderText = "Yetkazib beruvchi";
                searchProdDataGrid.Columns["Group"].HeaderText = "Guruhi";
                searchProdDataGrid.Columns["Quantity"].HeaderText = "Soni";
            }
        }

        private async void bunifuButton5_Click(object sender, EventArgs e)
        {
            waitForm.Show();
            itemService.ConfirmReceive(createModel.Receive, "1");
            foreach (var item in createModelList)
            {
                ReceiveItemModel itemModel = await itemService.CreateReceiveItem(item);
            }
            receiveDataGrid.DataSource = null;
            btnQabul.Enabled = true;
            Form1.ReceiveItemModel.Receive = 0;
            waitForm.Close();
        }

        private void searchProdDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string barcode = Form1.Products.Find(a => a.Barcode == searchProdDataGrid.SelectedCells[2].Value.ToString()).Barcode;
        }

        private void searchProdDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = Form1.Products.Find(a => a.Barcode == searchProdDataGrid.SelectedCells[4].Value.ToString()).Barcode;
                int prodId = int.Parse(searchProdDataGrid.SelectedCells[0].Value.ToString());
                MahsulotniQabulgaQushishPage qushishPage = new MahsulotniQabulgaQushishPage();
                qushishPage.FillForm(this, Form1.Products.Find(a => a.Id == prodId));
                qushishPage.ShowDialog();
                searchProdDataGrid.Visible = false;
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if(Form1.ReceiveItemModel.Receive == 0)
            {
                MessageBox.Show("Qabul boshlanmagan, Iltimos avval 'Qabulni boshlash' tugmasini bosing!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditQabulPage editQabul = new EditQabulPage();
            editQabul.FillForm(this,_qabulViewModel);
            editQabul.ShowDialog();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {

            receiveDataGrid.DataSource = null;
            btnQabul.Enabled = true;
            
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
