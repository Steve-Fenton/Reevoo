using Newtonsoft.Json;

namespace Reevoo.Message
{
    public class ReviewableShortFormatDetailResponse
    {
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        [JsonProperty(PropertyName = "review_count")]
        public int ReviewCount { get; set; }

        [JsonProperty(PropertyName = "average_score")]
        public string AverageScore { get; set; }
    }
}
