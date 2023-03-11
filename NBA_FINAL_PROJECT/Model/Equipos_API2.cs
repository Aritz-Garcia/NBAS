namespace NBA_FINAL_PROJECT.Model
{

    public class Equipos_API2
    {
        public _Internal1 _internal { get; set; }
        public League1 league { get; set; }
    }

    public class _Internal1
    {
        public string pubDateTime { get; set; }
        public string igorPath { get; set; }
        public string xslt { get; set; }
        public string xsltForceRecompile { get; set; }
        public string xsltInCache { get; set; }
        public string xsltCompileTimeMillis { get; set; }
        public string xsltTransformTimeMillis { get; set; }
        public string consolidatedDomKey { get; set; }
        public string endToEndTimeMillis { get; set; }
    }

    public class League1
    {
        public Standard1[] standard { get; set; }
        public Africa1[] africa { get; set; }
        public Sacramento1[] sacramento { get; set; }
        public Vega1[] vegas { get; set; }
        public Utah1[] utah { get; set; }
    }

    public class Standard1
    {
        public bool isNBAFranchise { get; set; }
        public bool isAllStar { get; set; }
        public string city { get; set; }
        public string altCityName { get; set; }
        public string fullName { get; set; }
        public string tricode { get; set; }
        public string teamId { get; set; }
        public string nickname { get; set; }
        public string urlName { get; set; }
        public string teamShortName { get; set; }
        public string confName { get; set; }
        public string divName { get; set; }
    }

    public class Africa1
    {
        public bool isNBAFranchise { get; set; }
        public bool isAllStar { get; set; }
        public string city { get; set; }
        public string altCityName { get; set; }
        public string fullName { get; set; }
        public string tricode { get; set; }
        public string teamId { get; set; }
        public string nickname { get; set; }
        public string urlName { get; set; }
        public string teamShortName { get; set; }
        public string confName { get; set; }
        public string divName { get; set; }
    }

    public class Sacramento1
    {
        public bool isNBAFranchise { get; set; }
        public bool isAllStar { get; set; }
        public string city { get; set; }
        public string altCityName { get; set; }
        public string fullName { get; set; }
        public string tricode { get; set; }
        public string teamId { get; set; }
        public string nickname { get; set; }
        public string urlName { get; set; }
        public string teamShortName { get; set; }
        public string confName { get; set; }
        public string divName { get; set; }
    }

    public class Vega1
    {
        public bool isNBAFranchise { get; set; }
        public bool isAllStar { get; set; }
        public string city { get; set; }
        public string altCityName { get; set; }
        public string fullName { get; set; }
        public string tricode { get; set; }
        public string teamId { get; set; }
        public string nickname { get; set; }
        public string urlName { get; set; }
        public string teamShortName { get; set; }
        public string confName { get; set; }
        public string divName { get; set; }
    }

    public class Utah1
    {
        public bool isNBAFranchise { get; set; }
        public bool isAllStar { get; set; }
        public string city { get; set; }
        public string altCityName { get; set; }
        public string fullName { get; set; }
        public string tricode { get; set; }
        public string teamId { get; set; }
        public string nickname { get; set; }
        public string urlName { get; set; }
        public string teamShortName { get; set; }
        public string confName { get; set; }
        public string divName { get; set; }
    }

}
