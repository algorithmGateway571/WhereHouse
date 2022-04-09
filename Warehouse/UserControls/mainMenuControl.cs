using System;
using System.Windows.Forms;

namespace Warehouse.UserControls
{
    public partial class mainMenuControl : UserControl
    {
        public mainMenuControl()
        {
            InitializeComponent();
        }

        private void Ombor_btn_Click(object sender, EventArgs e)
        {
            Form1.menuService.showControl(Form1.mainPanelStatik, 2);
        }

        private void Qabul_btn_Click(object sender, EventArgs e)
        {
            Form1.menuService.showControl(Form1.mainPanelStatik, 3);
        }

        private void fakturaTayyorlash_btn_Click(object sender, EventArgs e)
        {
            Form1.menuService.showControl(Form1.mainPanelStatik, 4);
        }

        private void faktura_btn_Click(object sender, EventArgs e)
        {
            Form1.menuService.showControl(Form1.mainPanelStatik, 5);
        }
    }
}
