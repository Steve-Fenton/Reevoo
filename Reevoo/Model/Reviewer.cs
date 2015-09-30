using Newtonsoft.Json;

namespace Reevoo.Model
{
    public class Reviewer
    {
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "segment")]
        public string Segment { get; set; }

        [JsonProperty(PropertyName = "facebook_avatar_url")]
        public string FacebookAvatarUrl { get; set; }
    }
}
