using Newtonsoft.Json;

namespace Reevoo.Model
{
    public class FinderOptions
    {
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }
    }
}
