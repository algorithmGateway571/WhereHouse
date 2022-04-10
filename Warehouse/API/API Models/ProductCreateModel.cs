using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.API.API_Models
{
    public class ProductCreateModel
    {

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("preparer")]
        public string Preparer { get; set; }
        [JsonProperty("group")]
        public int Group { get; set; }
        [JsonProperty("barcode")]
        public string Barcode { get; set; }
        [JsonProperty("dollar")]
        public double Dollar { get; set; }
        [JsonProperty("sotish_dollar")]
        public double SotishDollar { get; set; }
        [JsonProperty("ombor")]
        public bool Ombor { get; set; }


    }
    public class ProductCreateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("preparer")]
        public string Preparer { get; set; }
        [JsonProperty("group")]
        public string Group { get; set; }
        [JsonProperty("barcode")]
        public string Barcode { get; set; }
        [JsonProperty("dollar")]
        public double Dollar { get; set; }
        [JsonProperty("sotish_dollar")]
        public double SotishDollar { get; set; }
        [JsonProperty("quantity")]
        public double Quantity { get; set; }

    }

}
