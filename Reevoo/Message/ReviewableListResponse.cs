using Newtonsoft.Json;
using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ReviewableListResponse
    {
        [JsonProperty(PropertyName = "summary")]
        public Summary Summary { get; set; }

        [JsonProperty(PropertyName = "reviewables")]
        public List<Reviewable> Reviewables { get; set; }
    }
}
