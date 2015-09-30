using Reevoo.Message;
using System;
using System.Net;

namespace Reevoo.Api
{
    public class ReviewApi : ApiBase
    {
        internal ReviewApi(string key, string secret, Uri baseUri) : base(key, secret, baseUri) { }

        /// <summary>
        /// A reviewable will have a number of reviews associated with it.
        /// We aggregate reviews so reviews that have been collected for other organisations may be included.Only published reviews will be included.
        /// http://reevoo.github.io/docs/reevooapi/review/review-list/
        /// </summary>
        /// <param name="trkref"></param>
        /// <param name="locale"></param>
        /// <param name="sku"></param>
        /// <returns></returns>
        public ReviewListResponse List(string trkref, string locale, string sku)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var safeLocale = WebUtility.UrlEncode(locale);
            var safeSku = WebUtility.UrlEncode(sku);
            var apiPath = $"v4/organisations/{safeTrkref}/reviews?locale={safeLocale}&sku={safeSku}";

            var response = GetResponseOfType<ReviewListResponse>(apiPath);

            return response;
        }

        /// <summary>
        /// Details for a single review.
        /// http://reevoo.github.io/docs/reevooapi/review/review-detail/
        /// </summary>
        /// <param name="trkref"></param>
        /// <param name="reviewId"></param>
        /// <returns></returns>
        public ReviewDetailResponse Detail(string trkref, int reviewId)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var safereviewId = WebUtility.UrlEncode(reviewId.ToString());
            var apiPath = $"v4/reviews/{safereviewId}?trkref={safeTrkref}";

            var response = GetResponseOfType<ReviewDetailResponse>(apiPath);

            return response;
        }
    }
}
