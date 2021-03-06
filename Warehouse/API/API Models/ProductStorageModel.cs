using Newtonsoft.Json;

namespace Warehouse.API.API_Models
{
    public class ProductStorageModel
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
