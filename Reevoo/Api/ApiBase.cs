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
            T response = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = BaseUri;
                client.DefaultRequestHeaders.Authorization = GetAuthorizationHeader();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(APPLICATION_JSON));

                HttpResponseMessage httpResponse = client.GetAsync(apiPath).Result;

                if (httpResponse.IsSuccessStatusCode)
                {
                    response = httpResponse.Content.ReadAsAsync<T>().Result;
                }
                else
                {
                    throw new Exception($"Request failed with status {httpResponse.StatusCode} and reason {httpResponse.ReasonPhrase}");
                }
            }

            return response;
        }

        protected AuthenticationHeaderValue GetAuthorizationHeader()
        {
            var byteArray = Encoding.ASCII.GetBytes($"{Key}:{Secret}");
            return new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }
    }
}
