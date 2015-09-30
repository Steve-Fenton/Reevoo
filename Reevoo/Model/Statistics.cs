using Newtonsoft.Json;

namespace Reevoo.Model
{
    public class Statistics
    {
        [JsonProperty(PropertyName = "summation")]
        public double Summation { get; set; }

        [JsonProperty(PropertyName = "respondents")]
        public int Respondents { get; set; }
    }
}
