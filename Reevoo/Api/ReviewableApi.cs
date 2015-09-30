using Reevoo.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Reevoo.Api
{
    public class ReviewableApi : ApiBase
    {
        internal ReviewableApi(string key, string secret, Uri baseUri) : base(key, secret, baseUri) { }

        /// <summary>
        /// An organisation will have a number of reviewables associated with it.
        /// Reviewables returned from this end point will all relate directly to products and services supplied by the organisation.
        /// http://reevoo.github.io/docs/reevooapi/reviewable/reviewable-list/
        /// </summary>
        /// <param name="trkref"></param>
        /// <returns></returns>
        public ReviewableListResponse List(string trkref)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var apiPath = $"v4/organisations/{safeTrkref}/reviewables";

            var response = GetResponseOfType<ReviewableListResponse>(apiPath);

            return response;
        }

        /// <summary>
        /// Provides reviews with a short format version of reviewables of the specified organisation.
        /// All reviwables of the organisation are returned.
        /// This functionality is however enabled only for some organisations.
        /// Response is cached on the server side and refreshed on a daily basis.
        /// The attribute “date_time_created” shows the date/time when the list was last generated.
        /// Note: The server will return { status: 406 } if the specified organisation is not supported by this endpoint.
        /// http://reevoo.github.io/docs/reevooapi/reviewable/reviewable-short-format-list/
        /// </summary>
        /// <param name="trkref"></param>
        /// <returns></returns>
        public ReviewableShortFormatListResponse ShortFormatList(string trkref)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var apiPath = $"v4/organisations/{safeTrkref}/reviewables?format=short";

            var response = GetResponseOfType<ReviewableShortFormatListResponse>(apiPath);

            return response;
        }

        /// <summary>
        /// Provides reviews with a short format version of reviewables of the specified organisation.
        /// This endpoint can be used by any organisation.
        /// This functionality is however enabled only for some organisations.
        /// Response is cached on the server side and refreshed on a daily basis.
        /// The attribute “date_time_created” shows the date/time when the list was last generated.
        /// http://reevoo.github.io/docs/reevooapi/reviewable/reviewable-short-format-list/
        /// </summary>
        /// <param name="trkref"></param>
        /// <param name="skus"></param>
        /// <returns></returns>
        public ReviewableShortFormatListResponse ShortFormatList(string trkref, IEnumerable<string> skus)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var safeSkus = skus.Select(s => WebUtility.UrlEncode(s));
            var apiPath = $"v4/organisations/{safeTrkref}/reviewables?format=short&skus={string.Join(",", safeSkus)}";

            var response = GetResponseOfType<ReviewableShortFormatListResponse>(apiPath);

            return response;
        }

        /// <summary>
        /// A reviewable is anything that reviews can be requested for, it is often a product or service that an organisation provides but could be a group or series of products.
        /// Reviews are aggregated for a group of reviewables and a number of organisations.
        /// If the organisation making the request has international aggregation turned on, reviews will be returned for all locales, otherwise reviews will only be returned for the organisation’s locale.
        /// http://reevoo.github.io/docs/reevooapi/reviewable/reviewable-detail/
        /// </summary>
        /// <param name="trkref"></param>
        /// <param name="locale"></param>
        /// <param name="sku"></param>
        /// <returns></returns>
        public ReviewableDetailResponse Detail(string trkref, string locale, string sku)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var safeLocale = WebUtility.UrlEncode(locale);
            var safeSku = WebUtility.UrlEncode(sku);
            var apiPath = $"v4/organisations/{safeTrkref}/reviewable?locale={safeLocale}&sku={safeSku}";

            var response = GetResponseOfType<ReviewableDetailResponse>(apiPath);

            return response;
        }

        /// <summary>
        /// Returns a short set of key values for the reviewable, including the review count and average score.
        /// http://reevoo.github.io/docs/reevooapi/reviewable/reviewable-short-format-detail/
        /// </summary>
        /// <param name="trkref"></param>
        /// <param name="locale"></param>
        /// <param name="sku"></param>
        /// <returns></returns>
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
