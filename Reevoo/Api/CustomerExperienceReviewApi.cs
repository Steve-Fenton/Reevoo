using Reevoo.Message;
using System;
using System.Net;

namespace Reevoo.Api
{
    public class CustomerExperienceReviewApi : ApiBase
    {
        internal CustomerExperienceReviewApi(string key, string secret, Uri baseUri) : base(key, secret, baseUri) { }

        /// <summary>
        /// An organisation will have a number of customer experience reviews associated with it.
        /// Only published customer experience reviews will be included.
        /// http://reevoo.github.io/docs/reevooapi/customer-experience-review/customer-experience-review-list/
        /// </summary>
        /// <param name="trkref"></param>
        /// <returns></returns>
        public CustomerExperienceReviewListResponse List(string trkref)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var apiPath = $"v4/organisations/{safeTrkref}/customer_experience_reviews";

            var response = GetResponseOfType<CustomerExperienceReviewListResponse>(apiPath);

            return response;
        }

        /// <summary>
        /// Details for a single customer experience review.
        /// http://reevoo.github.io/docs/reevooapi/customer-experience-review/customer-experience-review-detail/
        /// </summary>
        /// <param name="trkref"></param>
        /// <param name="reviewId"></param>
        /// <returns></returns>
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
