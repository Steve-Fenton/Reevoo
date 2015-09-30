using Newtonsoft.Json;
using System.Collections.Generic;

namespace Reevoo.Model
{
    public class CustomerExperienceScores
    {
        [JsonProperty(PropertyName = "percentage_who_would_recommend")]
        public int PercentageWhoWouldRecommend { get; set; }

        [JsonProperty(PropertyName = "number_of_retailer_rating_reviews")]
        public int NumberOfRetailerRatingReviews { get; set; }

        [JsonProperty(PropertyName = "percentage_happy_with_delivery")]
        public int PercentageHappyWithDelivery { get; set; }

        [JsonProperty(PropertyName = "number_of_retailer_delivery_reviews")]
        public int NumberOfRetailerDeliveryReviews { get; set; }

        [JsonProperty(PropertyName = "percentage_happy_with_customer_service")]
        public int PercentageHappyWithCustomerService { get; set; }

        [JsonProperty(PropertyName = "number_of_retailer_service_reviews")]
        public int NumberOfRetailerServiceReviews { get; set; }
    }
}
