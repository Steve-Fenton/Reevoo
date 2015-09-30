using System.Collections.Generic;

namespace Reevoo.Model
{
    public class CustomerExperienceReview
    {
        public object branch_attribution { get; set; }
        public string purchase_date { get; set; }
        public Reviewer reviewer { get; set; }
        public List<Response> responses { get; set; }
    }
}
