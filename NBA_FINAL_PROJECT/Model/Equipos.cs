namespace NBA_FINAL_PROJECT.Model
{

    public class Equipos
    {
        public Datum1[] data { get; set; }
        public Meta1 meta { get; set; }
    }

    public class Meta1
    {
        public int total_pages { get; set; }
        public int current_page { get; set; }
        public object next_page { get; set; }
        public int per_page { get; set; }
        public int total_count { get; set; }
    }

    public class Datum1
    {
        public int id { get; set; }
        public string abbreviation { get; set; }
        public string city { get; set; }
        public string conference { get; set; }
        public string division { get; set; }
        public string full_name { get; set; }
        public string name { get; set; }
    }

}
