using Newtonsoft.Json;

namespace Reevoo.Model
{
    public class FastResponse
    {
        [JsonProperty(PropertyName = "response")]
        public string Response { get; set; }

        [JsonProperty(PropertyName = "respondent")]
        public Respondent Respondent { get; set; }

        [JsonProperty(PropertyName = "organisation")]
        public Organisation Organisation { get; set; }
    }
}
