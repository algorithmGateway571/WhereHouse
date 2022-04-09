using System;
using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.UserControls;
using Warehouse.ViewModels;

namespace Warehouse.CRUDForms
{
    public partial class MahsulotniQabulgaQushishPage : Form
    {
        ProductStorageModel storageModel { get; set; }
        MahsulotQabuliControl qabuliControl { get; set; }
        public MahsulotniQabulgaQushishPage()
        {
            InitializeComponent();
        }

        public void FillForm(MahsulotQabuliControl mahsulotQabuli, ProductStorageModel productStorage)
        {
            qabuliControl = mahsulotQabuli;
            storageModel = productStorage;
            txtName.Text = productStorage.Name;
            //txtQuantity.Text = productStorage.Quantity.ToString();

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Add_btn_Click(object sender, EventArgs e)
        {

            MahsulotQabulViewModel mahsulotQabul = new MahsulotQabulViewModel()
            {
                Receiveid = Form1.ReceiveItemModel.Receive,
                ProdName = storageModel.Name,
                ProdBarcode = storageModel.Barcode,
                ProdDeliver = storageModel.Preparer,
                ProdGroup = storageModel.Group,
                Dollar = double.Parse(txtDollar.Text),
                SotishDollar = double.Parse(txtSotishDollar.Text),
                Quantity = double.Parse(txtQuantity.Text)
            };
            qabuliControl.FillDataGrid(mahsulotQabul);
            this.Close();
        }
    }
}
