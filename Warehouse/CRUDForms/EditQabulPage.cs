using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Input;
using Warehouse.API.API_Models;
using Warehouse.UserControls;
using Warehouse.ViewModels;

namespace Warehouse.CRUDForms
{
    public partial class EditQabulPage : Form
    {
        MahsulotQabulViewModel _qabulViewModel { get; set; }
        MahsulotQabuliControl _qabuliControl { get; set; }
        public EditQabulPage()
        {
            InitializeComponent();
        }

        public void FillForm(MahsulotQabuliControl qabuliControl,MahsulotQabulViewModel qabulViewModel)
        {
            _qabuliControl = qabuliControl;
            txtName.Text = qabulViewModel.ProdName;
            txtDollar.Text = qabulViewModel.Dollar.ToString();
            txtSotishDollar.Text = qabulViewModel.SotishDollar.ToString();
            txtQuantity.Text = qabulViewModel.Quantity.ToString();
        }

        private void edit_btn_Click(object sender, System.EventArgs e)
        {
            MahsulotQabulViewModel itemCreateModel = new MahsulotQabulViewModel()
            {
                ProdName = txtName.Text,
                ProdBarcode = _qabulViewModel.ProdBarcode,
                ProdDeliver = _qabulViewModel.ProdDeliver,
                ProdGroup = _qabulViewModel.ProdGroup,
                Dollar = double.Parse(txtDollar.Text),
                SotishDollar = double.Parse(txtSotishDollar.Text),
                Quantity = double.Parse(txtQuantity.Text),
            };
            _qabuliControl.FillDataGrid(itemCreateModel);
            Close();
            
        }

        private void cancel_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9^.]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtName_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txtDollar_TextChanged(object sender, System.EventArgs e)
        {
            Regex regex = new Regex("[^0-9^.]");
            if (!regex.IsMatch(txtDollar.Text))
            {
                return;
            }
        }
    }
}
