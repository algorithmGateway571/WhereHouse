using Newtonsoft.Json;
using System;

namespace Warehouse.API.API_Models
{
    public class ReceiveModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("deliver")]
        public int DeliverId { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
    }
}
