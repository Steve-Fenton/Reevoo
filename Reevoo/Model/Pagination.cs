namespace Reevoo.Model
{
    public class Pagination
    {
        public int total_entries { get; set; }
        public int total_entries_with_content { get; set; }
        public int total_pages { get; set; }
        public int current_page { get; set; }
        public int per_page { get; set; }
        public int? previous_page { get; set; }
        public int? next_page { get; set; }
    }
}
