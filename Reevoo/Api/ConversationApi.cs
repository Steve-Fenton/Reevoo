using Reevoo.Message;
using System;
using System.Net;

namespace Reevoo.Api
{
    public class ConversationApi : ApiBase
    {
        internal ConversationApi(string key, string secret, Uri baseUri) : base(key, secret, baseUri) { }

        public ConversationListResponse List(string trkref, string locale, string sku)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var safeLocale = WebUtility.UrlEncode(locale);
            var safeSku = WebUtility.UrlEncode(sku);
            var apiPath = $"v4/organisations/{safeTrkref}/conversations?locale={safeLocale}&sku={safeSku}";

            var response = GetResponseOfType<ConversationListResponse>(apiPath);

            return response;
        }

        public ConversationDetailResponse Detail(int conversationId)
        {
            var safeConversationId = WebUtility.UrlEncode(conversationId.ToString());
            var apiPath = $"/v4/conversations/{safeConversationId}";

            var response = GetResponseOfType<ConversationDetailResponse>(apiPath);

            return response;
        }
    }
}
