using System.Windows.Forms;
using Warehouse.UserControls;

namespace Warehouse.UI_Services
{
    public class MenuService
    {
        FacturaControl facturaControl = new FacturaControl();
        FakturaTayyorlashControl tayyorlashControl = new FakturaTayyorlashControl();
        MahsulotQabuliControl mahsulotQabuli = new MahsulotQabuliControl();
        OmbordagiMahsulotlarControl ombordagiMahsulotlar = new OmbordagiMahsulotlarControl();
        mainMenuControl mainMenuControl = new mainMenuControl();
        public void showControl(Panel mainPanel, int menuName)
        {
            mainPanel.Controls.Clear();
            switch (menuName)
            {
                case 1:
                    mainMenuControl.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(mainMenuControl);
                    break;
                case 2:
                    ombordagiMahsulotlar.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(ombordagiMahsulotlar);
                    break;
                case 3:
                    mahsulotQabuli.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(mahsulotQabuli);
                    break;
                case 4:
                    tayyorlashControl.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(tayyorlashControl);
                    break;
                case 5:
                    facturaControl.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(facturaControl);
                    break;

            }
        }
    }
}
