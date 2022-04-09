using System.Windows.Forms;

namespace Warehouse.CRUDForms
{
    public partial class YangiMahsulotPage : Form
    {
        public YangiMahsulotPage()
        {
            InitializeComponent();
            foreach (var item in Form1.Groups)
            {
                comboGroup.Items.Add(item.Name);
            }
        }


    }
}
