using Newtonsoft.Json;
using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class OrganisationListResponse
    {
        [JsonProperty(PropertyName = "summary")]
        public Summary Summary { get; set; }

        [JsonProperty(PropertyName = "organisations")]
        public List<Organisation> Organisations { get; set; }
    }
}
