using Newtonsoft.Json;
using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ReviewListResponse
    {
        [JsonProperty(PropertyName = "summary")]
        public Summary Summary { get; set; }

        [JsonProperty(PropertyName = "reviews")]
        public List<Review> Reviews { get; set; }
    }
}
