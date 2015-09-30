using Newtonsoft.Json;
using System.Collections.Generic;

namespace Reevoo.Model
{
    public class Conversation
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "question")]
        public string Question { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty(PropertyName = "helpful")]
        public int Helpful { get; set; }

        [JsonProperty(PropertyName = "unhelpful")]
        public int Unhelpful { get; set; }

        [JsonProperty(PropertyName = "embeddable")]
        public bool Embeddable { get; set; }

        [JsonProperty(PropertyName = "retailer_locale")]
        public string RetailerLocale { get; set; }

        [JsonProperty(PropertyName = "answers_count")]
        public int AnswersCount { get; set; }

        [JsonProperty(PropertyName = "answers")]
        public List<Answer> Answers { get; set; }
    }
}
