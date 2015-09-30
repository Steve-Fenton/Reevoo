using Newtonsoft.Json;

namespace Reevoo.Model
{
    public class Answer
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "response")]
        public string Response { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "town")]
        public string Town { get; set; }

        [JsonProperty(PropertyName = "job_title")]
        public string JobTitle { get; set; }

        [JsonProperty(PropertyName = "reviewer_segment")]
        public string ReviewerSegment { get; set; }

        [JsonProperty(PropertyName = "helpful")]
        public int Helpful { get; set; }

        [JsonProperty(PropertyName = "unhelpful")]
        public int Unhelpful { get; set; }

        [JsonProperty(PropertyName = "review_url")]
        public string ReviewUrl { get; set; }

        [JsonProperty(PropertyName = "review_locale")]
        public string ReviewLocale { get; set; }

        [JsonProperty(PropertyName = "reviewer_facebook_url")]
        public string ReviewerFacebookUrl { get; set; }

        [JsonProperty(PropertyName = "response_type")]
        public string ResponseType { get; set; }

        [JsonProperty(PropertyName = "retailer_name")]
        public string RetailerName { get; set; }

        [JsonProperty(PropertyName = "retailer_image_url")]
        public string RetailerImageUrl { get; set; }
    }
}
