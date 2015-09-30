using Newtonsoft.Json;
using Reevoo.Model;

namespace Reevoo.Message
{
    public class ReviewableDetailResponse
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "has_reviews")]
        public bool HasReviews { get; set; }

        [JsonProperty(PropertyName = "has_image")]
        public bool HasImage { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "finder_options")]
        public FinderOptions FinderOptions { get; set; }

        [JsonProperty(PropertyName = "reviews_path")]
        public string ReviewsPath { get; set; }

        [JsonProperty(PropertyName = "organisation_url")]
        public string OrganisationUrl { get; set; }

        [JsonProperty(PropertyName = "organisation_url_with_reviews")]
        public string OrganisationUrlWithReviews { get; set; }
    }
}
