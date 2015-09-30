using Newtonsoft.Json;

namespace Reevoo.Model
{
    public class ReviewableCondensed
    {
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        [JsonProperty(PropertyName = "review_count")]
        public int ReviewCount { get; set; }

        [JsonProperty(PropertyName = "average_score")]
        public double AverageScore { get; set; }
    }
}
