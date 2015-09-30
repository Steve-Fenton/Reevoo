using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ReviewDetailResponse
    {
        public int id { get; set; }
        public int overall_score { get; set; }
        public int helpful { get; set; }
        public int not_helpful { get; set; }
        public string good_points { get; set; }
        public string bad_points { get; set; }
        public object general_comments { get; set; }
        public List<FastResponse> fast_responses { get; set; }
        public string customer_ref { get; set; }
        public string order_ref { get; set; }
        public bool embeddable { get; set; }
        public string confirmed_purchaser_text { get; set; }
        public Reviewer reviewer { get; set; }
        public List<Facet> facets { get; set; }
        public string publish_date { get; set; }
        public string purchase_date { get; set; }
        public string delivery_date { get; set; }
    }
}
