using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class OrganisationListResponse
    {
        public Summary summary { get; set; }
        public List<Organisation> organisations { get; set; }
    }
}
