using Newtonsoft.Json;
using System.Collections.Generic;

namespace Reevoo.Model
{
    public class Facet
    {
        [JsonProperty(PropertyName = "question_id")]
        public int QuestionId { get; set; }

        [JsonProperty(PropertyName = "translation_key")]
        public string TranslationKey { get; set; }

        [JsonProperty(PropertyName = "display_text")]
        public string SisplayText { get; set; }

        [JsonProperty(PropertyName = "is_active")]
        public bool IsActive { get; set; }

        [JsonProperty(PropertyName = "is_public")]
        public bool IsPublic { get; set; }

        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [JsonProperty(PropertyName = "statistics")]
        public Statistics Statistics { get; set; }
    }
}
