using Newtonsoft.Json;

namespace Reevoo.Model
{
    public class Respondent
    {
        [JsonProperty(PropertyName = "custom_name")]
        public string CustomName { get; set; }

        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        [JsonProperty(PropertyName = "job_title")]
        public string JobTitle { get; set; }
    }
}
