using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Warehouse.API.API_Models;

namespace Warehouse.UserControls
{
    public partial class FakturaTayyorlashControl : UserControl
    {
        public List<ProductStorageModel> ProductList = new List<ProductStorageModel>();
        public FakturaTayyorlashControl()
        {
            InitializeComponent();
            searchType_comboBox.SelectedIndex = 0;
            foreach (var item in Form1.Filials)
            {
                comboFilial.Items.Add(item.Name);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
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

        }
    }
}
