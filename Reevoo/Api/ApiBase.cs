using Reevoo.Exceptions;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Reevoo.Api
{
    public class ApiBase
    {
        private const string APPLICATION_JSON = "application/json";

        private readonly string Key;
        private readonly string Secret;
        private readonly Uri BaseUri;

        public ApiBase(string key, string secret, Uri baseUri)
        {
            Key = key;
            Secret = secret;
            BaseUri = baseUri;
        }

        protected T GetResponseOfType<T>(string apiPath) where T : class
        {
            using (var client = GetHttpClient())
            {
                HttpResponseMessage httpResponse = GetHttpResponse(client, apiPath);
                ValidateHttpResponse(httpResponse);
                return httpResponse.Content.ReadAsAsync<T>().Result;
            }
        }

        private HttpClient GetHttpClient()
        {
            var client = new HttpClient
            {
                BaseAddress = BaseUri,
            };

            client.DefaultRequestHeaders.Authorization = GetAuthorizationHeader();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(APPLICATION_JSON));

            return client;
        }

        private AuthenticationHeaderValue GetAuthorizationHeader()
        {
            var byteArray = Encoding.ASCII.GetBytes($"{Key}:{Secret}");
            return new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

        private static HttpResponseMessage GetHttpResponse(HttpClient client, string apiPath)
        {
            HttpResponseMessage httpResponse = null;
            try
            {
                httpResponse = client.GetAsync(apiPath).Result;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex);
            }

            return httpResponse;
        }

        private static void ValidateHttpResponse(HttpResponseMessage httpResponse)
        {
            if (httpResponse.IsSuccessStatusCode == false)
            {
                throw new ApiException(httpResponse);
            }
        }
    }
}
