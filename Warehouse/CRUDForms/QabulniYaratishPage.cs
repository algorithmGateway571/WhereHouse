using System;
using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.API.APIServices;

namespace Warehouse.CRUDForms
{
    public partial class QabulniYaratishPage : Form
    {
        ReceiveService receiveService = new ReceiveService();
        DeliverService deliverService = new DeliverService();
        ReceiveModel receiveModel { get; set; }
        public QabulniYaratishPage()
        {
            InitializeComponent();
            foreach (var item in Form1.Delivers)
            {
                comboDeliver.Items.Add(item.Name);
            }
        }

        private void newDeliver_btn_Click(object sender, EventArgs e)
        {

            comboDeliver.Visible = false;
            txtDeliver.Visible = true;
            lblPhone.Visible = txtPhone.Visible = true;

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void addNew_btn_Click(object sender, EventArgs e)
        {
            if (comboDeliver.Visible)
            {
                receiveModel = new ReceiveModel()
                {
                    Name = txtRecieveName.Text,
                    DeliverId = Form1.Delivers.Find(a => a.Name == comboDeliver.SelectedItem.ToString()).Id,
                    Date = DateTime.Now,
                    Status = 0
                };
                ReceiveModel model = await receiveService.CreateReceive(receiveModel);
                receiveModel = model;
                if (model == null)
                {
                    MessageBox.Show("Qabul qilish bajarilmadi");
                }
                else
                {
                    MessageBox.Show("Mahsulot qabuli muvaffaqiyatli qo'shildi!");
                }

            }
            else if (txtDeliver.Visible)
            {
                DeliverModel deliverModel = new DeliverModel()
                {
                    Name = txtDeliver.Text,
                    Phone1 = txtPhone.Text,
                };
                DeliverModel deliver = await deliverService.CreateDeliver(deliverModel);
                receiveModel = new ReceiveModel()
                {
                    Name = txtRecieveName.Text,
                    DeliverId = deliver.Id,
                    Date = DateTime.Now,
                    Status = 0
                };

                ReceiveModel model = await receiveService.CreateReceive(receiveModel);
                receiveModel = model;
                if (model == null || deliver == null)
                {
                    MessageBox.Show("Qabul qilish bajarilmadi");
                }
                else
                {
                    MessageBox.Show("Mahsulot qabuli muvaffaqiyatli qo'shildi!");
                }
            }
            Form1.ReceiveItemModel.Receive = receiveModel.Id;
            this.Close();
        }

        private void comboDeliver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
