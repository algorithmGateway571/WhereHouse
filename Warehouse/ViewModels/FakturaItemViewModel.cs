using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.ViewModels
{
    public class FakturaItemViewModel
    {
        public int index { get; set; }
        public int Id { get; set; }
        public string ProdName { get; set; }
        public string ProdBarcode { get; set; }
        public string ProdPreparer { get; set; }
        public string ProdGroup { get; set; }
        public double Body_dollar { get; set; }
        public double Dollar { get; set; }
        public double Quantity { get; set; }
        public string Measurement { get; set; }
    }
}
