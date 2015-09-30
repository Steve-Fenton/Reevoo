using Reevoo.Message;
using System;
using System.Net;

namespace Reevoo.Api
{
    public class ReviewableApi : ApiBase
    {
        internal ReviewableApi(string key, string secret, Uri baseUri) : base(key, secret, baseUri) { }

        public ReviewableListResponse List(string trkref)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var apiPath = $"v4/organisations/{safeTrkref}/reviewables";

            var response = GetResponseOfType<ReviewableListResponse>(apiPath);

            return response;
        }

        public ReviewableShortFormatListResponse ShortFormatList(string trkref)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var apiPath = $"v4/organisations/{safeTrkref}/reviewables?format=short";

            var response = GetResponseOfType<ReviewableShortFormatListResponse>(apiPath);

            return response;
        }

        public ReviewableDetailResponse Detail(string trkref, string locale, string sku)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var safeLocale = WebUtility.UrlEncode(locale);
            var safeSku = WebUtility.UrlEncode(sku);
            var apiPath = $"v4/organisations/{safeTrkref}/reviewable?locale={safeLocale}&sku={safeSku}";

            var response = GetResponseOfType<ReviewableDetailResponse>(apiPath);

            return response;
        }

        public ReviewableShortFormatDetailResponse ShortFormatDetail(string trkref, string locale, string sku)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var safeLocale = WebUtility.UrlEncode(locale);
            var safeSku = WebUtility.UrlEncode(sku);
            var apiPath = $"v4/organisations/{safeTrkref}/reviewable?locale={safeLocale}&sku={safeSku}&format=short";

            var response = GetResponseOfType<ReviewableShortFormatDetailResponse>(apiPath);

            return response;
        }
    }
}
