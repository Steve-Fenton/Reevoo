using Newtonsoft.Json;
using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class OrganisationDetailResponse
    {
        [JsonProperty(PropertyName = "trkref")]
        public string Trkref { get; set; }

        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "reviewables_path")]
        public string ReviewablesPath { get; set; }

        [JsonProperty(PropertyName = "customer_experience_reviews_path")]
        public string CustomerExperienceReviewsPath { get; set; }

        [JsonProperty(PropertyName = "organisation_url_with_reviews")]
        public string OrganisationUrlWithReviews { get; set; }

        [JsonProperty(PropertyName = "customer_experience_scores")]
        public CustomerExperienceScores CustomerExperienceScores { get; set; }
    }
}
