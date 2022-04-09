using Newtonsoft.Json;

namespace Warehouse.API.API_Models
{
    public class FilialModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("qarz_som")]
        public int QarzSom { get; set; }
        [JsonProperty("qarz_dol")]
        public int QarzDollar { get; set; }
        [JsonProperty("savdo_puli_som")]
        public int SavdoPuliSom { get; set; }
        [JsonProperty("savdo_puli_dol")]
        public int SavdoPuliDollar { get; set; }
        [JsonProperty("nasiya_foiz")]
        public double NasiyaFoiz { get; set; }
    }
}
