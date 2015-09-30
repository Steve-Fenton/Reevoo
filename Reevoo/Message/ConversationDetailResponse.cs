using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ConversationDetailResponse
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string question { get; set; }
        public string created_at { get; set; }
        public int helpful { get; set; }
        public int unhelpful { get; set; }
        public bool embeddable { get; set; }
        public string retailer_locale { get; set; }
        public int answers_count { get; set; }
        public List<Answer> answers { get; set; }
    }
}
