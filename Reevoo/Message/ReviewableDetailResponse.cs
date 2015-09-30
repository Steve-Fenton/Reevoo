using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ReviewableDetailResponse
    {
        public string name { get; set; }
        public bool has_reviews { get; set; }
        public bool has_image { get; set; }
        public string image_url { get; set; }
        public FinderOptions finder_options { get; set; }
        public string reviews_path { get; set; }
        public string organisation_url { get; set; }
        public string organisation_url_with_reviews { get; set; }
    }
}
