using Newtonsoft.Json;

namespace Warehouse.API.API_Models
{
    public class ReceiveItemModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("receive")]
        public int Receive { get; set; }
        [JsonProperty("product")]
        public ProductModel Product { get; set; }
        [JsonProperty("dollar")]
        public double Dollar { get; set; }
        [JsonProperty("sotish_dollar")]
        public double SotishDollar { get; set; }
        [JsonProperty("quantity")]
        public double Quantity { get; set; }
    }

    public class ReceiveItemCreateModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("receive")]
        public int Receive { get; set; }
        [JsonProperty("product")]
        public string Product { get; set; }
        [JsonProperty("dollar")]
        public double Dollar { get; set; }
        [JsonProperty("sotish_dollar")]
        public double SotishDollar { get; set; }
        [JsonProperty("quantity")]
        public double Quantity { get; set; }
    }
}
