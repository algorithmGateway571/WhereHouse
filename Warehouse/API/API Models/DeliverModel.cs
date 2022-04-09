using Newtonsoft.Json;

namespace Warehouse.API.API_Models
{
    public class DeliverModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("phone1")]
        public string Phone1 { get; set; }
        [JsonProperty("phone2")]
        public string Phone2 { get; set; }
        [JsonProperty("som")]
        public double Som { get; set; }
        [JsonProperty("dollar")]
        public double Dollar { get; set; }
        [JsonProperty("difference")]
        public double Difference { get; set; }
    }
}
