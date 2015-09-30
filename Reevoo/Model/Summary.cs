using System.Collections.Generic;

namespace Reevoo.Model
{
    public class Summary
    {
        public List<Facet> facets { get; set; }
        public Pagination pagination { get; set; }
    }
}
