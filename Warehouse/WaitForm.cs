using System;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public WaitForm(Form parent)
        {
            InitializeComponent();
            if (parent != null)
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                //this.Location = new Point(parent.Location.X + parent.Width / 2 - this.Width / 2,
                //    parent.Location.Y + parent.Height / 2 - this.Height / 2);
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        public void CloseWaitForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void WaitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
