using Newtonsoft.Json;
using System.Collections.Generic;

namespace Reevoo.Model
{
    public class CustomerExperienceReview
    {
        [JsonProperty(PropertyName = "branch_attribution")]
        public string BranchAttribution { get; set; }

        [JsonProperty(PropertyName = "purchase_date")]
        public string PurchaseDate { get; set; }

        [JsonProperty(PropertyName = "reviewer")]
        public Reviewer Reviewer { get; set; }

        [JsonProperty(PropertyName = "responses")]
        public List<Response> Responses { get; set; }
    }
}
