using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Warehouse.UI_Services.ImportFromExcel;

namespace Warehouse.CRUDForms
{
    public partial class NotFoundProductsPage : Form
    {
        public NotFoundProductsPage()
        {
            InitializeComponent();
        }
        public void FillDataGrid(List<Products> ProductsNotFound)
        {
            productDataGrid.DataSource = ProductsNotFound;

        }

    }
}
