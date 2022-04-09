using Newtonsoft.Json;

namespace Warehouse.API.API_Models
{
    public class FakturaItemModel
    {
        [JsonProperty("factura")]
        public int FakturaId { get; set; }
        [JsonProperty("product")]
        public string ProductBarcode { get; set; }
        [JsonProperty("body_dollar")]
        public double BodyDollar { get; set; }
        [JsonProperty("dollar")]
        public double Dollar { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
