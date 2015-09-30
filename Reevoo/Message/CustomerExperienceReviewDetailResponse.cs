using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class CustomerExperienceReviewDetailResponse
    {
        public object branch_attribution { get; set; }
        public string publish_date { get; set; }
        public string purchase_date { get; set; }
        public string delivery_date { get; set; }
        public string customer_ref { get; set; }
        public string order_ref { get; set; }
        public string confirmed_purchaser_text { get; set; }
        public List<FastResponse> fast_responses { get; set; }
        public Reviewer reviewer { get; set; }
        public List<Response> responses { get; set; }
    }
}
