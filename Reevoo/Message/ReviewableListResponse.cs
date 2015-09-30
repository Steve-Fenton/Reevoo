using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ReviewableListResponse
    {
        public Summary summary { get; set; }
        public List<Reviewable> reviewables { get; set; }
    }
}
