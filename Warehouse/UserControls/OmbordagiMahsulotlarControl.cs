using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Warehouse.API.API_Models;
using Warehouse.API.APIServices;

namespace Warehouse.UserControls
{
    public partial class OmbordagiMahsulotlarControl : UserControl
    {
        BarcodeLib.Barcode barCode = new BarcodeLib.Barcode();

        ProductListService productListService = new ProductListService();
        public List<ProductStorageModel> ProductList = new List<ProductStorageModel>();
        WaitForm waitForm = new WaitForm();
        public OmbordagiMahsulotlarControl()
        {
            InitializeComponent();
            search_comboBox.SelectedIndex = 0;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            mahsulotDataGrid.DataSource = null;
            if (search_comboBox.SelectedIndex == 0)
            {
                ProductList = Form1.Products.Where(a => a.Barcode.Contains(bunifuTextBox1.Text)).ToList();
                mahsulotDataGrid.DataSource = ProductList;

            }
            else if (search_comboBox.SelectedIndex == 1)
            {
                ProductList = Form1.Products.Where(a => a.Name.Contains(bunifuTextBox1.Text)).ToList();
                mahsulotDataGrid.DataSource = ProductList;

            }

            if (ProductList != null)
            {
                mahsulotDataGrid.Columns["Id"].Visible = false;
                mahsulotDataGrid.Columns["Name"].HeaderText = "Mahsulot nomi";
                mahsulotDataGrid.Columns["Barcode"].HeaderText = "Shrix kodi";
                mahsulotDataGrid.Columns["Preparer"].HeaderText = "Ishlab chiqaruvchi";
                mahsulotDataGrid.Columns["Group"].HeaderText = "Guruhi";
                mahsulotDataGrid.Columns["Quantity"].HeaderText = "Soni";
            }

        }

        private void mahsulotDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = mahsulotDataGrid.SelectedCells[2].Value.ToString();
                string prodName = mahsulotDataGrid.SelectedCells[1].Value.ToString();
                lblName.Text = prodName;
                productBarCode_txt.Text = barcode;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (productBarCode_txt.Text.Trim() == "")
            {
                return;
            }
            if (txtWidth.Text.Trim() == "")
            {
                return;
            }
            if (txtHeight.Text.Trim() == "")
            {
                return;
            }
            int nW = Convert.ToInt32(txtWidth.Text.Trim());
            int nH = Convert.ToInt32(txtHeight.Text.Trim());

            barCode.Alignment = BarcodeLib.AlignmentPositions.CENTER;

            BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
            type = BarcodeLib.TYPE.CODE128;
            try
            {
                if (type != BarcodeLib.TYPE.UNSPECIFIED)
                {
                    barCode.IncludeLabel = true;
                    barCode.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType),
                        "RotateNoneFlipNone", true);
                    pictureBarcode.Image = barCode.Encode(type, productBarCode_txt.Text, Color.Black, Color.White, nW, nH);

                }
                pictureBarcode.Width = pictureBarcode.Image.Width;
                pictureBarcode.Height = pictureBarcode.Image.Height;
                lblBarName.Text = lblName.Text;
                if (lblBarName.Text.Length - pictureBarcode.Width / 2 >= 0)
                {
                    lblBarName.Text = lblName.Text.Substring(0, pictureBarcode.Width / 2);
                    lblBarName.Text += "\n" + lblName.Text.Substring(pictureBarcode.Width / 2);
                }

                panel1.Width = pictureBarcode.Width;
                panel1.Height = pictureBarcode.Image.Height + 42;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void OmbordagiMahsulotlarControl_Load(object sender, EventArgs e)
        {
            GetProductsList();
        }

        private async void GetProductsList()
        {
            waitForm.Show();
            mahsulotDataGrid.DataSource = null;
            Form1.Products = await productListService.GetProducts();
            mahsulotDataGrid.DataSource = Form1.Products;
            mahsulotDataGrid.Refresh();
            waitForm.Close();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Print(barCode_panel);
        }

        PrintDialog prntprvw = new PrintDialog();
        PrintDocument pntdoc = new PrintDocument();
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            prntprvw.Document = pntdoc;
            pntdoc.PrintPage += new PrintPageEventHandler(pntdoc_printpage);
            if (prntprvw.ShowDialog() == DialogResult.OK)
            {
                pntdoc.Print();
            }

        }
        public void pntdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }
        Bitmap memoryimg;
        public void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void bunifuTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
