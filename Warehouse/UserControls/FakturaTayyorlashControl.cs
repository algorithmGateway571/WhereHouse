using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Warehouse.API.API_Models;

namespace Warehouse.UserControls
{
    public partial class FakturaTayyorlashControl : UserControl
    {
        public ProductStorageModel ProductList = new ProductStorageModel();
        public FakturaTayyorlashControl()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            searchDataGrid.DataSource = null;
            if (search_comboBox.SelectedIndex == 0)
            {
                ProductList = Form1.Products.Where(a => a.Barcode == search_mahsulot_txt.Text).FirstOrDefault();
                searchDataGrid.DataSource = ProductList;

            }
            else if (search_comboBox.SelectedIndex == 1)
            {
                ProductList = Form1.Products.Where(a => a.Name == search_mahsulot_txt.Text).FirstOrDefault();
                searchDataGrid.DataSource = ProductList;
            }
        }
    }
}
