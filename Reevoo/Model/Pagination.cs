using Newtonsoft.Json;

namespace Reevoo.Model
{
    public class Pagination
    {
        [JsonProperty(PropertyName = "total_entries")]
        public int TotalEntries { get; set; }

        [JsonProperty(PropertyName = "total_entries_with_content")]
        public int TotalEntriesWithContent { get; set; }

        [JsonProperty(PropertyName = "total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty(PropertyName = "current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty(PropertyName = "per_page")]
        public int PerPage { get; set; }

        [JsonProperty(PropertyName = "previous_page")]
        public int? PreviousPage { get; set; }

        [JsonProperty(PropertyName = "next_page")]
        public int? NextPage { get; set; }
    }
}
