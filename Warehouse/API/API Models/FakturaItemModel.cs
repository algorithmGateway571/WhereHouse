using Newtonsoft.Json;

namespace Warehouse.API.API_Models
{
    public class FakturaItemModel
    {
        [JsonProperty("faktura")]
        public int FakturaId { get; set; }
        [JsonProperty("product")]
        public int ProductId { get; set; }
        [JsonProperty("body_dollar")]
        public double BodyDollar { get; set; }
        [JsonProperty("dollar")]
        public double Dollar { get; set; }
        [JsonProperty("quantity")]
        public double Quantity { get; set; }
    }

    public class FakturaItemCreateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("faktura")]
        public int FakturaId { get; set; }
        [JsonProperty("product")]
        public ProductFakturaModel Product { get; set; }
        [JsonProperty("body_dollar")]
        public double BodyDollar { get; set; }
        [JsonProperty("dollar")]
        public double Dollar { get; set; }
        [JsonProperty("quantity")]
        public double Quantity { get; set; }
        [JsonProperty("price_diff")]
        public double PriceDifference { get; set; }
    }
}
