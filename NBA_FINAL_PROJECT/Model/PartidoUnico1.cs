﻿namespace NBA_FINAL_PROJECT.Model
{

    public class PartidoUnico1
    {
        public int id { get; set; }
        public string date { get; set; }
        public Home_Team2 home_team { get; set; }
        public int home_team_score { get; set; }
        public int period { get; set; }
        public bool postseason { get; set; }
        public int season { get; set; }
        public string status { get; set; }
        public string time { get; set; }
        public Visitor_Team2 visitor_team { get; set; }
        public int visitor_team_score { get; set; }
    }

    public class Home_Team2
    {
        public int id { get; set; }
        public string abbreviation { get; set; }
        public string city { get; set; }
        public string conference { get; set; }
        public string division { get; set; }
        public string full_name { get; set; }
        public string name { get; set; }
    }

    public class Visitor_Team2
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