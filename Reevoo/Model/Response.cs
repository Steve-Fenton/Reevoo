using Newtonsoft.Json;

namespace Reevoo.Model
{
    public class Response
    {
        [JsonProperty(PropertyName = "display_key")]
        public string DisplayKey { get; set; }

        [JsonProperty(PropertyName = "answer")]
        public string Answer { get; set; }
    }
}
