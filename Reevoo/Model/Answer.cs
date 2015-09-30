namespace Reevoo.Model
{
    public class Answer
    {
        public int id { get; set; }
        public string response { get; set; }
        public string created_at { get; set; }
        public string first_name { get; set; }
        public string town { get; set; }
        public object job_title { get; set; }
        public string reviewer_segment { get; set; }
        public int helpful { get; set; }
        public int unhelpful { get; set; }
        public string review_url { get; set; }
        public string review_locale { get; set; }
        public object reviewer_facebook_url { get; set; }
        public string response_type { get; set; }
        public object retailer_name { get; set; }
        public object retailer_image_url { get; set; }
    }
}
