using Reevoo.Message;
using System;
using System.Net;

namespace Reevoo.Api
{
    public class ConversationApi : ApiBase
    {
        internal ConversationApi(string key, string secret, Uri baseUri) : base(key, secret, baseUri) { }

        /// <summary>
        /// Returns all the conversations that are associated with a specific product.
        /// http://reevoo.github.io/docs/reevooapi/conversation/conversation-list/
        /// </summary>
        /// <param name="trkref"></param>
        /// <param name="locale"></param>
        /// <param name="sku"></param>
        /// <returns></returns>
        public ConversationListResponse List(string trkref, string locale, string sku)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var safeLocale = WebUtility.UrlEncode(locale);
            var safeSku = WebUtility.UrlEncode(sku);
            var apiPath = $"v4/organisations/{safeTrkref}/conversations?locale={safeLocale}&sku={safeSku}";

            var response = GetResponseOfType<ConversationListResponse>(apiPath);

            return response;
        }

        /// <summary>
        /// Returns details for a single conversation.
        /// http://reevoo.github.io/docs/reevooapi/conversation/conversation-detail/
        /// </summary>
        /// <param name="conversationId"></param>
        /// <returns></returns>
        public ConversationDetailResponse Detail(int conversationId)
        {
            var safeConversationId = WebUtility.UrlEncode(conversationId.ToString());
            var apiPath = $"/v4/conversations/{safeConversationId}";

            var response = GetResponseOfType<ConversationDetailResponse>(apiPath);

            return response;
        }
    }
}
