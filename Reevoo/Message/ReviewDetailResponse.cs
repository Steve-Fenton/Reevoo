using Newtonsoft.Json;
using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ReviewDetailResponse
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "overall_score")]
        public int OverallScore { get; set; }

        [JsonProperty(PropertyName = "helpful")]
        public int Helpful { get; set; }

        [JsonProperty(PropertyName = "not_helpful")]
        public int NotHelpful { get; set; }

        [JsonProperty(PropertyName = "good_points")]
        public string GoodPoints { get; set; }

        [JsonProperty(PropertyName = "bad_points")]
        public string BadPoints { get; set; }

        [JsonProperty(PropertyName = "general_comments")]
        public object GeneralComments { get; set; }

        [JsonProperty(PropertyName = "fast_responses")]
        public List<FastResponse> FastResponses { get; set; }

        [JsonProperty(PropertyName = "customer_ref")]
        public string CustomerRef { get; set; }

        [JsonProperty(PropertyName = "order_ref")]
        public string OrderRef { get; set; }

        [JsonProperty(PropertyName = "embeddable")]
        public bool Embeddable { get; set; }

        [JsonProperty(PropertyName = "confirmed_purchaser_text")]
        public string ConfirmedPurchaserText { get; set; }

        [JsonProperty(PropertyName = "reviewer")]
        public Reviewer Reviewer { get; set; }

        [JsonProperty(PropertyName = "facets")]
        public List<Facet> Facets { get; set; }

        [JsonProperty(PropertyName = "publish_date")]
        public string PublishDate { get; set; }

        [JsonProperty(PropertyName = "purchase_date")]
        public string PurchaseDate { get; set; }

        [JsonProperty(PropertyName = "delivery_date")]
        public string DeliveryDate { get; set; }
    }
}
