using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.API.APIServices;
using Warehouse.UI_Services;

namespace Warehouse
{
    public partial class Form1 : Form
    {
        public static List<ProductStorageModel> Products = new List<ProductStorageModel>();
        public static List<GroupModel> Groups = new List<GroupModel>();
        public static List<DeliverModel> Delivers = new List<DeliverModel>();
        public static List<FilialModel> Filials = new List<FilialModel>();
        public static List<ReceiveModel> receiveModels = new List<ReceiveModel>();
        public static ReceiveItemModel ReceiveItemModel = new ReceiveItemModel();

        public static MenuService menuService = new MenuService();
        public static Panel mainPanelStatik;
        ProductListService productListService = new ProductListService();
        GroupService groupService = new GroupService();
        DeliverService deliverService = new DeliverService();
        FilialService filialService = new FilialService();
        WaitFormFunc waitForm = new WaitFormFunc();

        public Form1()
        {
            InitializeComponent();
            mainPanelStatik = main_panel;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            menuService.showControl(main_panel, 1);
            waitForm.Show(this);
            Products = await productListService.GetProducts();
            Groups = await groupService.GetGroups();
            Delivers = await deliverService.GetDelivers();
            Filials = await filialService.GetFilials();
            //Thread thread = new Thread(GetAllData);
            //thread.Start();
            waitForm.Close();

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            menuService.showControl(main_panel, 1);
        }

        private void ombor_btn_Click(object sender, EventArgs e)
        {
            menuService.showControl(main_panel, 2);

        }

        private void Qabul_btn_Click(object sender, EventArgs e)
        {
            menuService.showControl(main_panel, 3);

        }

        private void FakturaTayyorlash_btn_Click(object sender, EventArgs e)
        {
            menuService.showControl(main_panel, 4);

        }

        private void Faktura_btn_Click(object sender, EventArgs e)
        {
            menuService.showControl(main_panel, 5);

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
