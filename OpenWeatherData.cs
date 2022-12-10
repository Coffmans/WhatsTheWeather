namespace WhatsTheWeather
{
    //public class OpenWeatherData
    //{

        public class OpenWeatherData
        {
            public OpenWeatherCoord coord { get; set; } = default!;
            public OpenWeatherDataData[] weather { get; set; } = default!;
            public string _base { get; set; }  = string.Empty;
            public OpenWeatherMain main { get; set; }= default!;
            public int visibility { get; set; }
            public OpenWeatherWind wind { get; set; } = default!;
            public OpenWeatherClouds clouds { get; set; } = default!;
            public int dt { get; set; }
            public OpenWeatherSys sys { get; set; } = default!;
            public int timezone { get; set; }
            public int id { get; set; }
            public string name { get; set; } = string.Empty;
            public int cod { get; set; }
        }

        public class OpenWeatherCoord
    {
            public float lon { get; set; }
            public float lat { get; set; }
        }

        public class OpenWeatherMain
    {
            public float temp { get; set; }
            public float feels_like { get; set; }
            public float temp_min { get; set; }
            public float temp_max { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }

        public class OpenWeatherWind
    {
            public float speed { get; set; }
            public int deg { get; set; }
        }

        public class OpenWeatherClouds
    {
            public int all { get; set; }
        }

        public class OpenWeatherSys
    {
            public int type { get; set; }
            public int id { get; set; }
            public string country { get; set; } = string.Empty;
            public int sunrise { get; set; }
            public int sunset { get; set; }
        }

        public class OpenWeatherDataData
    {
            public int id { get; set; }
            public string main { get; set; } = string.Empty;
            public string description { get; set; } = string.Empty;
            public string icon { get; set; } = string.Empty;
    }

    //}
}
