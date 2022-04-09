using Newtonsoft.Json;

namespace Warehouse.API.API_Models
{
    public class GroupModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
