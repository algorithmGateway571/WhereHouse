using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.UserControls;
using Warehouse.ViewModels;

namespace Warehouse.CRUDForms
{
    public partial class EtidFakturaPage : Form
    {
        FakturaItemViewModel _fakturaItemViewModel { get; set; }
        FakturaTayyorlashControl tayyorlashControl { get; set; }
        public EtidFakturaPage()
        {
            InitializeComponent();
        }
        public void FillEditForm(FakturaTayyorlashControl fakturaTayyorlash, FakturaItemViewModel fakturaItem)
        {
            tayyorlashControl = fakturaTayyorlash;
            _fakturaItemViewModel = fakturaItem;
            txtName.Text = fakturaItem.ProdName;
            txtDollar.Text = fakturaItem.Dollar.ToString();
            txtQuantity.Text = fakturaItem.Quantity.ToString();
            
        }
        private void edit_btn_Click(object sender, System.EventArgs e)
        {
            FakturaItemViewModel fakturaItem = new FakturaItemViewModel()
            {
                index = _fakturaItemViewModel.index,
                Body_dollar =  _fakturaItemViewModel.Body_dollar,
                ProdGroup = _fakturaItemViewModel.ProdGroup,
                ProdName = _fakturaItemViewModel.ProdName,
                ProdPreparer = _fakturaItemViewModel.ProdPreparer,
                ProdBarcode = _fakturaItemViewModel.ProdBarcode,
                Dollar = double.Parse(txtDollar.Text),
                Quantity= double.Parse(txtQuantity.Text)
            };
            tayyorlashControl.EditDataGridItem(fakturaItem);
            Close();
        }

        private void cancel_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
