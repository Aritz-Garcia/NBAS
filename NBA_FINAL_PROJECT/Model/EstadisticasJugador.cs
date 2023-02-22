namespace NBA_FINAL_PROJECT.Model
{
    public class EstadisticasJugador
    {
        public Datum4[] data { get; set; }
    } 

    public class Datum4
    {
        public int games_played { get; set; }
        public int player_id { get; set; }
        public int season { get; set; }
        public string min { get; set; }
        public float fgm { get; set; }
        public float fga { get; set; }
        public float fg3m { get; set; }
        public float fg3a { get; set; }
        public float ftm { get; set; }
        public float fta { get; set; }
        public float oreb { get; set; }
        public float dreb { get; set; }
        public float reb { get; set; }
        public float ast { get; set; }
        public float stl { get; set; }
        public float blk { get; set; }
        public float turnover { get; set; }
        public float pf { get; set; }
        public float pts { get; set; }
        public float fg_pct { get; set; }
        public float fg3_pct { get; set; }
        public float ft_pct { get; set; }
    }

}
