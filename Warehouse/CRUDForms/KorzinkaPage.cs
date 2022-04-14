using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.API.APIServices;
using Warehouse.UI_Services;
using Warehouse.UserControls;
using Warehouse.ViewModels;

namespace Warehouse.CRUDForms
{
    public partial class KorzinkaPage : Form
    {
        ProductStorageModel _storageModel { get; set; }
        FakturaItemService fakturaItemService = new FakturaItemService();
        FakturaService fakturaService = new FakturaService();
        FakturaTayyorlashControl _fakturaTayyorlash { get; set; }
        WaitFormFunc waitForm = new WaitFormFunc();

        public KorzinkaPage()
        {
            InitializeComponent();
        }

        public void FillKorzinka(FakturaTayyorlashControl fakturaTayyorlash, ProductStorageModel storageModel)
        {
            _fakturaTayyorlash = fakturaTayyorlash;
            _storageModel = storageModel;
            txtName.Text = storageModel.Name;
            txtDollar.Text = storageModel.Dollar.ToString();
            txtSoldPrice.Text = storageModel.SotishDollar.ToString();
            txtOmborQuan.Text = storageModel.Quantity.ToString();
        }

        private void cancel_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private async void AddFaktura_btn_Click(object sender, System.EventArgs e)
        {
            FakturaItemViewModel itemViewModel = new FakturaItemViewModel()
            {
                Id = _storageModel.Id,
                ProdName = _storageModel.Name,
                ProdBarcode = _storageModel.Barcode,
                ProdGroup = _storageModel.Group,
                ProdPreparer = _storageModel.Preparer,
                Body_dollar = double.Parse(txtDollar.Text),
                Dollar = double.Parse(txtSoldPrice.Text),
                Quantity = double.Parse(txtQuantity.Text),
                
            };
            _fakturaTayyorlash.FillDataGrid(itemViewModel);
            //await fakturaService.ConfirmFaktura(itemCreateResponse.FakturaId, "1");
            Close();

        }

        private void txtQuantity_TextChanged(object sender, System.EventArgs e)
        {
            if(txtQuantity.Text != "")
            {
               if (_storageModel.Quantity < double.Parse(txtQuantity.Text))
                {
                    MessageBox.Show("Ombordagi qiymatdan ko'p kiritildi!", "Xabar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
