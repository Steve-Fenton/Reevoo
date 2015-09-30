using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ReviewableShortFormatListResponse
    {
        public Summary summary { get; set; }
        public List<ReviewableCondensed> reviewables { get; set; }
    }
}
