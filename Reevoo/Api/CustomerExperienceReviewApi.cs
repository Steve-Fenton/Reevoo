using Reevoo.Message;
using System;
using System.Net;

namespace Reevoo.Api
{
    public class CustomerExperienceReviewApi : ApiBase
    {
        internal CustomerExperienceReviewApi(string key, string secret, Uri baseUri) : base(key, secret, baseUri) { }

        public CustomerExperienceReviewListResponse List(string trkref)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var apiPath = $"v4/organisations/{safeTrkref}/customer_experience_reviews";

            var response = GetResponseOfType<CustomerExperienceReviewListResponse>(apiPath);

            return response;
        }

        public CustomerExperienceReviewDetailResponse Detail(string trkref, int reviewId)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var safereviewId = WebUtility.UrlEncode(reviewId.ToString());
            var apiPath = $"v4/customer_experience_reviews/{safereviewId}?trkref={safeTrkref}";

            var response = GetResponseOfType<CustomerExperienceReviewDetailResponse>(apiPath);

            return response;
        }
    }
}
