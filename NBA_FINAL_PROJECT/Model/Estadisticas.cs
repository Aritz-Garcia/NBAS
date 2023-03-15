namespace NBA_FINAL_PROJECT.Model
{

    public class Estadisticas
    {
        public Datum3[] data { get; set; }
        public Meta3 meta { get; set; }
    }

    public class Meta3
    {
        public int total_pages { get; set; }
        public int current_page { get; set; }
        public int? next_page { get; set; }
        public int per_page { get; set; }
        public int total_count { get; set; }
    }

    public class Datum3
    {
        public int id { get; set; }
        public int ast { get; set; }
        public int blk { get; set; }
        public int dreb { get; set; }
        public float? fg3_pct { get; set; }
        public int fg3a { get; set; }
        public int fg3m { get; set; }
        public float? fg_pct { get; set; }
        public int fga { get; set; }
        public int fgm { get; set; }
        public float? ft_pct { get; set; }
        public int fta { get; set; }
        public int ftm { get; set; }
        public Game3 game { get; set; }
        public string min { get; set; }
        public int oreb { get; set; }
        public int pf { get; set; }
        public Player3 player { get; set; }
        public int pts { get; set; }
        public int reb { get; set; }
        public int stl { get; set; }
        public Team3 team { get; set; }
        public int turnover { get; set; }
    }

    public class Game3
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int home_team_id { get; set; }
        public int home_team_score { get; set; }
        public int period { get; set; }
        public bool postseason { get; set; }
        public int season { get; set; }
        public string status { get; set; }
        public string time { get; set; }
        public int visitor_team_id { get; set; }
        public int visitor_team_score { get; set; }
    }

    public class Player3
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public int? height_feet { get; set; }
        public int? height_inches { get; set; }
        public string last_name { get; set; }
        public string? position { get; set; }
        public int team_id { get; set; }
        public int? weight_pounds { get; set; }
    }

    public class Team3
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
