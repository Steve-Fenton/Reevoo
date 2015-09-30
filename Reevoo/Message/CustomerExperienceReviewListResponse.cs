using Newtonsoft.Json;
using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class CustomerExperienceReviewListResponse
    {
        [JsonProperty(PropertyName = "customer_experience_reviews")]
        public List<CustomerExperienceReview> CustomerExperienceReviews { get; set; }
    }
}
