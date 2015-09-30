using System.Collections.Generic;

namespace Reevoo.Model
{
    public class Facet
    {
        public int question_id { get; set; }
        public string translation_key { get; set; }
        public string display_text { get; set; }
        public bool is_active { get; set; }
        public bool is_public { get; set; }
        public string tag { get; set; }
        public Statistics statistics { get; set; }
    }
}
