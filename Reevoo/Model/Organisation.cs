using Newtonsoft.Json;

namespace Reevoo.Model
{
    public class Organisation
    {
        [JsonProperty(PropertyName = "trkref")]
        public string Trkref { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "logo")]
        public string Logo { get; set; }
    }
}
