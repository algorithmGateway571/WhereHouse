using Newtonsoft.Json;
using System;

namespace Warehouse.API.API_Models
{
    public class FakturaCreateModel
    {
        [JsonProperty("filial")]
        public int Filial { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
    }
    public class FakturaCreateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("filial")]
        public string Filial { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("total_arrival_price")]
        public double TotalArrival_price { get; set; }
        [JsonProperty("total_selling_price")]
        public double TotalSelling_price { get; set; }
        [JsonProperty("total_diff")]
        public double TotalDifference { get; set; }
    }
}
