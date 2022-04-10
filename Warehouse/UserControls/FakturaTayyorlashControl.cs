using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.API.APIServices;
using Warehouse.CRUDForms;
using Warehouse.UI_Services;

namespace Warehouse.UserControls
{
    public partial class FakturaTayyorlashControl : UserControl
    {
        public List<ProductStorageModel> ProductList = new List<ProductStorageModel>();
        public List<FakturaItemCreateResponse> FakturaList = new List<FakturaItemCreateResponse>();
        FakturaService fakturaService = new FakturaService();
        WaitFormFunc waitForm = new WaitFormFunc();
        FakturaItemCreateResponse createResponse { get; set; }
        public FakturaTayyorlashControl()
        {
            InitializeComponent();
            searchType_comboBox.SelectedIndex = 0;

        }

        public void FillDataGrid(FakturaItemCreateResponse fakturaItemCreate)
        {
            createResponse = fakturaItemCreate;
            FakturaList.Add(fakturaItemCreate);
            fakturaDataGrid.DataSource = FakturaList;
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            FakturaCreateModel fakturaCreate = new FakturaCreateModel()
            {
                Filial = Form1.Filials.Find(a => a.Name.Contains(comboFilial.SelectedItem.ToString())).Id,
                Status = 0
            };
            waitForm.Show();
            FakturaCreateResponse response= await fakturaService.CreateFaktura(fakturaCreate);
            Form1.Faktura = response;
            waitForm.Close();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
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

        private void searchDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            searchDataGrid.Visible = false;
            if (e.KeyCode == Keys.Enter)
            {
                ProductStorageModel storageModel = Form1.Products.Where(a => a.Barcode.Contains(searchDataGrid.SelectedCells[4].Value.ToString())).FirstOrDefault();
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
    }
}
