using System;
using System.Linq;
using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.API.APIServices;
using Warehouse.UserControls;
using Warehouse.ViewModels;

namespace Warehouse.CRUDForms
{
    public partial class YangiMahsulotPage : Form
    {
        ProductListService listProductService = new ProductListService();
        public string last_barcode = "", faktura_id;
        GroupService groupService = new GroupService();
        MahsulotQabuliControl qabuliControl { get; set; }
        public YangiMahsulotPage()
        {
            InitializeComponent();
            foreach (var item in Form1.Groups)
            {
                comboGroup.Items.Add(item.Name);
            }
        }
        public void SensReceive(MahsulotQabuliControl mahsulotQabuli)
        {
            qabuliControl = mahsulotQabuli;
        }

        private async void bunifuButton2_Click(object sender, System.EventArgs e)
        {
            if (txtGroup.Visible)
            {
                GroupModel groupModel = new GroupModel()
                {
                    Name = txtGroup.Text,
                };
                GroupModel model = await groupService.CreateGroup(groupModel);
                ProductCreateModel createModel = new ProductCreateModel()
                {
                    Name = txtName.Text,
                    Preparer = txtPreparer.Text,
                    Group = model.Id,
                    Barcode = txtBarcode.Text,
                    Dollar = double.Parse(txtDollar.Text),
                    SotishDollar = double.Parse(txtSotishDollar.Text),
                };
                ProductCreateResponse createResponse = await listProductService.CreateProduct(createModel);
                MahsulotQabulViewModel qabulViewModel = new MahsulotQabulViewModel()
                {
                    Receiveid = Form1.ReceiveItemModel.Receive,
                    ProdName = createResponse.Name,
                    ProdBarcode = createResponse.Barcode,
                    ProdDeliver = createResponse.Preparer,
                    ProdGroup = createResponse.Group,
                    Dollar = createResponse.Dollar,
                    SotishDollar = createResponse.SotishDollar,
                    Quantity = createResponse.Quantity
                };

                qabuliControl.FillDataGrid(qabulViewModel);
            }
            else if (comboGroup.Visible)
            {
                ProductCreateModel createModel = new ProductCreateModel()
                {
                    Name = txtName.Text,
                    Preparer = txtPreparer.Text,
                    Group = Form1.Groups.Find(a => a.Name == comboGroup.SelectedItem.ToString()).Id,
                    Barcode = txtBarcode.Text,
                    Dollar = double.Parse(txtDollar.Text),
                    SotishDollar = double.Parse(txtSotishDollar.Text),
                };
                ProductCreateResponse createResponse = await listProductService.CreateProduct(createModel);
                MahsulotQabulViewModel qabulViewModel = new MahsulotQabulViewModel()
                {
                    Receiveid = Form1.ReceiveItemModel.Receive,
                    ProdName = createResponse.Name,
                    ProdBarcode = createResponse.Barcode,
                    ProdDeliver = createResponse.Preparer,
                    ProdGroup = createResponse.Group,
                    Dollar = createResponse.Dollar,
                    SotishDollar = createResponse.SotishDollar,
                    Quantity = createResponse.Quantity
                };

                qabuliControl.FillDataGrid(qabulViewModel);
            }
            this.Close();
        }

        private void bunifuButton1_Click(object sender, System.EventArgs e)
        {
            txtGroup.Visible = true;
            comboGroup.Visible = false;
            
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
