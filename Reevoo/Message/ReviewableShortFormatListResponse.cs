using Newtonsoft.Json;
using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ReviewableShortFormatListResponse
    {
        [JsonProperty(PropertyName = "summary")]
        public Summary Summary { get; set; }

        [JsonProperty(PropertyName = "reviewables")]
        public List<ReviewableCondensed> Reviewables { get; set; }
    }
}
