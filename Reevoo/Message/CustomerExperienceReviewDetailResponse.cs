using Newtonsoft.Json;
using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class CustomerExperienceReviewDetailResponse
    {
        [JsonProperty(PropertyName = "branch_attribution")]
        public string BranchAttribution { get; set; }

        [JsonProperty(PropertyName = "purchase_date")]
        public string PurchaseDate { get; set; }

        [JsonProperty(PropertyName = "reviewer")]
        public Reviewer Reviewer { get; set; }

        [JsonProperty(PropertyName = "responses")]
        public List<Response> Responses { get; set; }

        [JsonProperty(PropertyName = "publish_date")]
        public string PublishDate { get; set; }

        [JsonProperty(PropertyName = "delivery_date")]
        public string DeliveryDate { get; set; }

        [JsonProperty(PropertyName = "customer_ref")]
        public string CustomerRef { get; set; }

        [JsonProperty(PropertyName = "order_ref")]
        public string OrderRef { get; set; }

        [JsonProperty(PropertyName = "confirmed_purchaser_text")]
        public string ConfirmedPurchaserText { get; set; }

        [JsonProperty(PropertyName = "fast_responses")]
        public List<FastResponse> FastResponses { get; set; }
    }
}
