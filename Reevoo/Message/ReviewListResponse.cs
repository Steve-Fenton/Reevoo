using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ReviewListResponse
    {
        public Summary summary { get; set; }
        public List<Review> reviews { get; set; }
    }
}
