using Newtonsoft.Json;

namespace AzureWebAPIWSD
{
    public class Item
    {

       [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "designation")]
        public string designation { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string email { get; set; }
        [JsonProperty(PropertyName = "partition")]
        public string Partition { get; set; }

    }
}
