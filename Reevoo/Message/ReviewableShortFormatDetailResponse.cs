using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ReviewableShortFormatDetailResponse
    {
        public string sku { get; set; }
        public int review_count { get; set; }
        public string average_score { get; set; }
    }
}
