using Newtonsoft.Json;

namespace Warehouse.API.API_Models
{
    public class ProductModel
    {

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("barcode")]
        public string Barcode { get; set; }
        [JsonProperty("preparer")]
        public string Preparer { get; set; }
        [JsonProperty("group")]
        public string Group { get; set; }
        [JsonProperty("measurement")]
        public string Measurement { get; set; }
    }

    public class ProductFakturaModel
    {

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("barcode")]
        public string Barcode { get; set; }
        [JsonProperty("preparer")]
        public string Preparer { get; set; }
        [JsonProperty("group")]
        public string Group { get; set; }
        [JsonProperty("measurement")]
        public string Measurement { get; set; }
    }
}
