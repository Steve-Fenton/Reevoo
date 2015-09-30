using Reevoo.Model;
using System.Collections.Generic;

namespace Reevoo.Message
{
    public class ConversationListResponse
    {
        public Summary summary { get; set; }
        public List<Conversation> conversations { get; set; }
    }
}
