using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.CRUDForms;
using Warehouse.UserControls;
using Warehouse.ViewModels;

namespace Warehouse.UI_Services
{
    public class ImportFromExcel
    {
        List<Products> ProductsNotFound = new List<Products>();
        public void ImportFromExcelDataReceive(Bunifu.UI.WinForms.BunifuDataGridView dataGridView, MahsulotQabuliControl fakturaTayyorlash)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel WorkBook|*.xlsx|Excel WorkBook 97-2003|*.xls", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        List<Products> products = ImportExcelData<Products>(ofd.InitialDirectory + ofd.FileName, "Лист1");
                        dataGridView.DataSource = products;
                        foreach (var item in products)
                        {
                            if (Form1.Products.Find(x => x.Barcode == item.Barcode)==null)
                            {
                                ProductsNotFound.Add(item);
                                continue;
                            }
                            else
                            {
                                MahsulotQabulViewModel itemViewModel = new MahsulotQabulViewModel()
                                {
                                    Index = item.Kodi,
                                    ProdName = item.Nomi,
                                    ProdBarcode = item.Barcode,
                                    ProdGroup = item.Guruh,
                                    ProdDeliver = item.Brend,
                                    Dollar = Math.Round(item.Tannarx, 2),
                                    SotishDollar = Math.Round(item.Sotuv, 2),
                                    Quantity = item.Soni
                                };
                                fakturaTayyorlash.FillDataGrid(itemViewModel);
                            }
                            
                        }
                        //if (ProductsNotFound != null)
                        //{
                        //    NotFoundProductsPage productsPage = new NotFoundProductsPage();
                        //    productsPage.FillDataGrid(ProductsNotFound);
                        //    productsPage.ShowDialog();
                        //}

                    }
                }
            }
            catch (Exception ex) { string errormsg = ex.ToString(); }
        }
        public void ImportFromExcelData(Bunifu.UI.WinForms.BunifuDataGridView dataGridView, FakturaTayyorlashControl fakturaTayyorlash)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel WorkBook|*.xlsx|Excel WorkBook 97-2003|*.xls", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        List<Products> products = ImportExcelData<Products>(ofd.InitialDirectory + ofd.FileName, "Лист1");
                        dataGridView.DataSource = products;
                        foreach (var item in products)
                        {
                            if (item.Soni > Form1.Products.Where(x=>x.Barcode==item.Barcode).Sum(a => a.Quantity))
                            {
                               // MessageBox.Show("Mahsulot yetarli emas!", "Xatolik", MessageBoxButtons.OK);
                                continue; 
                            }
                            if (Form1.Products.Find(x => x.Barcode == item.Barcode) ==null)
                            {
                                ProductsNotFound.Add(item);
                                continue;
                            }

                            FakturaItemViewModel itemViewModel = new FakturaItemViewModel()
                            {   
                                
                                Id = Form1.Products.Find(a => a.Barcode == item.Barcode && a.Quantity >= item.Soni).Id,
                                ProdName = item.Nomi,
                                ProdBarcode = item.Barcode,
                                ProdGroup = item.Guruh,
                                ProdPreparer = item.Brend,
                                Body_dollar = Math.Round(item.Tannarx,2),
                                Dollar = Math.Round(item.Sotuv, 2),
                                Quantity = item.Soni,
                               
                            };
                            fakturaTayyorlash.FillDataGrid(itemViewModel);
                        }
                        //if(ProductsNotFound != null)
                        //{
                        //    NotFoundProductsPage productsPage = new NotFoundProductsPage();
                        //    productsPage.FillDataGrid(ProductsNotFound);
                        //    productsPage.ShowDialog();
                        //}
                       
                    }
                }
            }
            catch (Exception ex) { string errormsg = ex.ToString(); }
        }

        public List<T> ImportExcelData<T>(string excelFilePath, string sheetName)
        {
            List<T> list = new List<T>();
            Type typeOfObject = typeof(T);
            using (IXLWorkbook workbook = new XLWorkbook(excelFilePath))
            {
                var worksheet = workbook.Worksheets.Where(w => w.Name == sheetName || w.Name == "Sheet1").First();
                var properties = typeOfObject.GetProperties();
                var columns = worksheet.FirstRow().Cells().Select((v, i) => new { Value = v.Value, Index = i + 1 });
                foreach (IXLRow row in worksheet.RowsUsed().Skip(3))
                {
                     T obj = (T)Activator.CreateInstance(typeOfObject);
                    foreach (var prop in properties)
                    {
                        int colIndex = columns.SingleOrDefault(c => c.Value.ToString() == prop.Name.ToString()).Index;
                        var val = row.Cell(colIndex).Value;
                        var type = prop.PropertyType;
                        prop.SetValue(obj, Convert.ChangeType(val, type));
                    }
                    list.Add(obj);
                }
            }
            return list;
        }

        public class Products
        {
            public int Kodi { get; set; }
            public string Nomi { get; set; }
            public int Soni { get; set; }
            public string Barcode { get; set; }
            public string Brend { get; set; }
            public double Sotuv { get; set; }
            public string Guruh { get; set; }
            public double Tannarx { get; set; }
        }

    }
}
