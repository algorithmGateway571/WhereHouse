using System.Collections.Generic;
using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.API.APIServices;

namespace Warehouse.UserControls
{
    public partial class FacturaControl : UserControl
    {
        FakturaService fakturaService = new FakturaService();
        FakturaItemService itemService = new FakturaItemService();
        List<FakturaCreateResponse> fakturaCreates = new List<FakturaCreateResponse>();
        List<FakturaItemCreateResponse> itemCreateResponses = new List<FakturaItemCreateResponse>();
        WaitForm waitForm = new WaitForm();
        public FacturaControl()
        {
            InitializeComponent();
        }

        private void search_filial_txt_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void FacturaControl_Load(object sender, System.EventArgs e)
        {
            GetFakturas();
        }

        public async void GetFakturas()
        {
            waitForm.Show();
            fakturaCreates =await fakturaService.GetFakturas();
            itemCreateResponses = await itemService.GetFakturaItems();
            FakturaDataGrid.DataSource = fakturaCreates;
            FakturaItemDataGrid.DataSource = itemCreateResponses;
            waitForm.Close();
        }
    }
}
