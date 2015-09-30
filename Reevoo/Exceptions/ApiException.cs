using System;
using System.Net.Http;

namespace Reevoo.Exceptions
{
    [Serializable]
    public class ApiException : ReevooException
    {
        public ApiException(HttpResponseMessage httpResponseMessage) : base(
            string.Format("Request failed. Status Code: {0}, Reason Phrase: {1}, URI: {2}",
                httpResponseMessage.StatusCode,
                httpResponseMessage.ReasonPhrase,
                httpResponseMessage.RequestMessage.RequestUri)
            ) { }

        public ApiException(Exception innerException) : base("Failed to connect to Reevoo, see inner exception for more detail.", innerException) { }
    }
}
