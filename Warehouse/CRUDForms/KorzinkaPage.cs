using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.API.APIServices;
using Warehouse.UI_Services;
using Warehouse.UserControls;

namespace Warehouse.CRUDForms
{
    public partial class KorzinkaPage : Form
    {
        ProductStorageModel _storageModel { get; set; }
        FakturaItemService fakturaItemService = new FakturaItemService();
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
            FakturaItemModel faktura = new FakturaItemModel()
            {
                FakturaId = Form1.Faktura.Id,
                ProductBarcode = _storageModel.Barcode,
                BodyDollar = _storageModel.Dollar,
                Dollar = double.Parse(txtSoldPrice.Text),
                Quantity = double.Parse(txtQuantity.Text),
            };
            waitForm.Show();
            FakturaItemCreateResponse itemCreateResponse = await fakturaItemService.CreateFakturaItem(faktura);
            _fakturaTayyorlash.FillDataGrid(itemCreateResponse);
            fakturaItemService.ConfirmFaktura(itemCreateResponse.FakturaId, "1");
            waitForm.Close();
            Close();

        }
    }
}
