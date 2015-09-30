using System.Collections.Generic;

namespace Reevoo.Model
{
    public class CustomerExperienceScores
    {
        public int percentage_who_would_recommend { get; set; }
        public int number_of_retailer_rating_reviews { get; set; }
        public int percentage_happy_with_delivery { get; set; }
        public int number_of_retailer_delivery_reviews { get; set; }
        public int percentage_happy_with_customer_service { get; set; }
        public int number_of_retailer_service_reviews { get; set; }
    }
}
