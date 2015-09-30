using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class OrganisationDetailResponse
    {
        public string trkref { get; set; }
        public string locale { get; set; }
        public string name { get; set; }
        public string reviewables_path { get; set; }
        public string customer_experience_reviews_path { get; set; }
        public string organisation_url_with_reviews { get; set; }
        public CustomerExperienceScores customer_experience_scores { get; set; }
    }
}
