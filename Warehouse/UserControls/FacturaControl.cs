using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.API.APIServices;
using Warehouse.ViewModels;

namespace Warehouse.UserControls
{
    public partial class FacturaControl : UserControl
    {
        FakturaService fakturaService = new FakturaService();
        FakturaItemService itemService = new FakturaItemService();
        List<FakturaCreateResponse> fakturaCreates = new List<FakturaCreateResponse>();
        List<FakturaItemCreateResponse> itemCreateResponses = new List<FakturaItemCreateResponse>();
        List<FakturaItemViewModel> fakturaItemViews = new List<FakturaItemViewModel>();

        List<ReceiveModel> receiveModels = new List<ReceiveModel>();
        List<ReceiveItemModel> receiveItemModels = new List<ReceiveItemModel>();
        List<MahsulotQabulViewModel> qabulViewModels = new List<MahsulotQabulViewModel>();
        ReceiveService receiveService = new ReceiveService();
        ReceiveItemService receiveItemService = new ReceiveItemService();

        WaitForm waitForm = new WaitForm();
        public FacturaControl()
        {
            InitializeComponent();
            historyType_comboBox.SelectedIndex = 0;
        }

        private void search_filial_txt_TextChanged(object sender, System.EventArgs e)
        {
            if(historyType_comboBox.SelectedIndex == 0)
            {
                fakturaCreates = fakturaCreates.Where(a => a.Filial.Contains(search_filial_txt.Text)).ToList();
                FakturaDataGrid.DataSource = null;
                FakturaDataGrid.DataSource = fakturaCreates;
                FakturaDataGrid.Refresh();
            }
            else
            {
                receiveModels = receiveModels.Where(a => a.Name.Contains(search_filial_txt.Text)).ToList();
                FakturaDataGrid.DataSource = null;
                FakturaDataGrid.DataSource = receiveModels;
                FakturaDataGrid.Refresh();
            }

        }

        private void FacturaControl_Load(object sender, System.EventArgs e)
        {
            GetFakturas();
        }

        public async void GetFakturas()
        {
            int i = 1;
            if(historyType_comboBox.SelectedIndex == 0)
            {
                fakturaCreates = await fakturaService.GetFakturas();
                itemCreateResponses = await itemService.GetFakturaItems();
                foreach (var item in itemCreateResponses)
                {
                    fakturaItemViews.Add(new FakturaItemViewModel()
                    {
                        index = i++,
                        ProdName = item.Product.Name,
                        ProdBarcode = item.Product.Barcode,
                        ProdPreparer = item.Product.Preparer,
                        ProdGroup = item.Product.Preparer,
                        Dollar = item.Dollar,
                        Body_dollar = item.BodyDollar,
                        Quantity = item.Quantity,
                    });
                }
                FakturaDataGrid.DataSource = fakturaCreates;
                FakturaItemDataGrid.DataSource = fakturaItemViews;

                FakturaDataGrid.Columns["Id"].Visible = false;
                FakturaDataGrid.Columns["Filial"].HeaderText = "Filial";
                FakturaDataGrid.Columns["Date"].HeaderText = "Sana";
                FakturaDataGrid.Columns["Status"].HeaderText = "status";

                FakturaItemDataGrid.Columns["index"].HeaderText = "T/r";
                FakturaItemDataGrid.Columns["ProdName"].HeaderText = "Mahsulot";
                FakturaItemDataGrid.Columns["ProdBarcode"].HeaderText = "Shtrix kod";
                FakturaItemDataGrid.Columns["ProdGroup"].HeaderText = "Guruh";
                FakturaItemDataGrid.Columns["ProdPreparer"].HeaderText = "Preparer";
                FakturaItemDataGrid.Columns["Dollar"].HeaderText = "Sotish narxi $";
                FakturaItemDataGrid.Columns["Body_dollar"].HeaderText = "Tan narxi $";
                FakturaItemDataGrid.Columns["Quantity"].HeaderText = "Soni";

            }
            else
            {
                receiveModels = await receiveService.GetReceives();
                receiveItemModels = await receiveItemService.GetReceiveItems();
                foreach (var item in receiveItemModels)
                {
                    qabulViewModels.Add(new MahsulotQabulViewModel()
                    {
                        Index = i++,
                        ProdName = item.Product.Name,
                        ProdBarcode = item.Product.Barcode,
                        ProdDeliver = item.Product.Preparer,
                        ProdGroup = item.Product.Group,
                        Dollar = item.Dollar,
                        SotishDollar = item.SotishDollar,
                        Receiveid = item.Receive,
                        Quantity = item.Quantity,
                    });
                };
                FakturaDataGrid.DataSource = receiveModels;
                FakturaDataGrid.Columns["Id"].Visible = false;
                FakturaDataGrid.Columns["Name"].HeaderText = "Qabul momi";
                FakturaDataGrid.Columns["Date"].HeaderText = "Qabul sanasi";
                FakturaDataGrid.Columns["DeliverId"].HeaderText = "Yetkazib beruvchi";
                FakturaDataGrid.Columns["Status"].HeaderText = "Holadi";

                FakturaItemDataGrid.DataSource = qabulViewModels;
                FakturaItemDataGrid.Columns["Index"].HeaderText = "T/r";
                FakturaItemDataGrid.Columns["ProdName"].HeaderText = "Mahsulot";
                FakturaItemDataGrid.Columns["ProdBarcode"].HeaderText = "Shtrix kod";
                FakturaItemDataGrid.Columns["ProdDeliver"].HeaderText = "Yetkazuvchi";
                FakturaItemDataGrid.Columns["ProdGroup"].HeaderText = "Guruh";
                FakturaItemDataGrid.Columns["Dollar"].HeaderText = "Tan narx";
                FakturaItemDataGrid.Columns["SotishDollar"].HeaderText = "Sotish narx";
                FakturaItemDataGrid.Columns["Quantity"].HeaderText = "Soni";
            }
        }

        private void historyType_comboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            GetFakturas();
        }

        private void bunifuButton8_Click(object sender, System.EventArgs e)
        {

        }
    }
}
