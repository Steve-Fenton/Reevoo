using Newtonsoft.Json;
using System.Collections.Generic;

namespace Reevoo.Model
{
    public class Summary
    {
        [JsonProperty(PropertyName = "Facets")]
        public List<Facet> Facets { get; set; }

        [JsonProperty(PropertyName = "pagination")]
        public Pagination Pagination { get; set; }
    }
}
