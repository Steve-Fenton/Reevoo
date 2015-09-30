using Newtonsoft.Json;
using System.Collections.Generic;

namespace Reevoo.Model
{
    public class Review
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
        public string GeneralComments { get; set; }

        [JsonProperty(PropertyName = "customer_ref")]
        public string CustomerRef { get; set; }

        [JsonProperty(PropertyName = "order_ref")]
        public string OrderRef { get; set; }

        [JsonProperty(PropertyName = "embeddable")]
        public bool Embeddable { get; set; }

        [JsonProperty(PropertyName = "reviewer")]
        public Reviewer Reviewer { get; set; }

        [JsonProperty(PropertyName = "facets")]
        public List<Facet> Facets { get; set; }
    }
}
