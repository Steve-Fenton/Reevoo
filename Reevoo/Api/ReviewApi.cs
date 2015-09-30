using Reevoo.Message;
using System;
using System.Net;

namespace Reevoo.Api
{
    public class ReviewApi : ApiBase
    {
        internal ReviewApi(string key, string secret, Uri baseUri) : base(key, secret, baseUri) { }

        public ReviewListResponse List(string trkref, string locale, string sku)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var safeLocale = WebUtility.UrlEncode(locale);
            var safeSku = WebUtility.UrlEncode(sku);
            var apiPath = $"v4/organisations/{safeTrkref}/reviews?locale={safeLocale}&sku={safeSku}";

            var response = GetResponseOfType<ReviewListResponse>(apiPath);

            return response;
        }

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
