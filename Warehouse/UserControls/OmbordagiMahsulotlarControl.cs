using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Warehouse.API.API_Models;

namespace Warehouse.UserControls
{
    public partial class OmbordagiMahsulotlarControl : UserControl
    {
        public List<ProductStorageModel> ProductList = new List<ProductStorageModel>();
        public OmbordagiMahsulotlarControl()
        {
            InitializeComponent();
            search_comboBox.SelectedIndex = 0;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            mahsulotDataGrid.DataSource = null;
            if (search_comboBox.SelectedIndex == 0)
            {
                ProductList = Form1.Products.Where(a => a.Barcode.Contains(bunifuTextBox1.Text)).ToList();
                mahsulotDataGrid.DataSource = ProductList;

            }
            else if (search_comboBox.SelectedIndex == 1)
            {
                ProductList = Form1.Products.Where(a => a.Name.Contains(bunifuTextBox1.Text)).ToList();
                mahsulotDataGrid.DataSource = ProductList;

            }

            if (ProductList != null)
            {
                mahsulotDataGrid.Columns["Id"].Visible = false;
                mahsulotDataGrid.Columns["Name"].HeaderText = "Mahsulot nomi";
                mahsulotDataGrid.Columns["Barcode"].HeaderText = "Shrix kodi";
                mahsulotDataGrid.Columns["Preparer"].HeaderText = "Yetkazib beruvchi";
                mahsulotDataGrid.Columns["Group"].HeaderText = "Guruhi";
                mahsulotDataGrid.Columns["Quantity"].HeaderText = "Soni";
            }

        }

        private void mahsulotDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = mahsulotDataGrid.SelectedCells[2].Value.ToString();

            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
