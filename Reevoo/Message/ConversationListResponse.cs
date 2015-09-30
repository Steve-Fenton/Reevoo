using Newtonsoft.Json;
using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ConversationListResponse
    {
        [JsonProperty(PropertyName = "summary")]
        public Summary Summary { get; set; }

        [JsonProperty(PropertyName = "conversations")]
        public List<Conversation> Conversations { get; set; }
    }
}
