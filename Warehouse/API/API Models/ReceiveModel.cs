using Newtonsoft.Json;
using System;

namespace Warehouse.API.API_Models
{
    public class ReceiveModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("deliver")]
        public int DeliverId { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class ReceiveResponseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("deliver")]
        public string Deliver { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("total_arrival_price")]
        public double TotalArrivalPrice { get; set; }
        [JsonProperty("total_selling_price")]
        public double TotalSellingPrice { get; set; }
    }
}
