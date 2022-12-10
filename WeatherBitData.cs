namespace WhatsTheWeather
{
    //public class WeatherBitData
    //{

        public class WeatherBitData
        {
            public int count { get; set; }
            public Datum[] data { get; set; } = default!;
        }

        public class Datum
        {
            public float app_temp { get; set; }
            public int aqi { get; set; }
            public string city_name { get; set; } = default!;
            public int clouds { get; set; }
            public string country_code { get; set; } = default!;
            public string datetime { get; set; } = default!;
            public float dewpt { get; set; }
            public float dhi { get; set; }
            public float dni { get; set; }
            public float elev_angle { get; set; }
            public float ghi { get; set; }
            public string gust { get; set; } = default!;
            public int h_angle { get; set; }
            public float lat { get; set; }
            public float lon { get; set; }
            public string ob_time { get; set; } = default!;
            public string pod { get; set; } = default!;
            public object precip { get; set; } = default!;
            public float pres { get; set; }
            public int rh { get; set; }
            public float slp { get; set; }
            public object snow { get; set; } = default!;
            public float solar_rad { get; set; }
            public string[] sources { get; set; } = default!;
            public string state_code { get; set; } = default!;
            public string station { get; set; } = default!;
            public string sunrise { get; set; } = default!;
            public string sunset { get; set; } = default!;
            public float temp { get; set; }
            public string timezone { get; set; } = default!;
            public int ts { get; set; }
            public float uv { get; set; }
            public int vis { get; set; }
            public WeatherBitWeather weather { get; set; } = default!;
            public string wind_cdir { get; set; } = default!;
            public string wind_cdir_full { get; set; } = default!;
            public int wind_dir { get; set; }
            public float wind_spd { get; set; }
        }

        public class WeatherBitWeather
    {
            public string description { get; set; } = default!;
            public int code { get; set; }
            public string icon { get; set; } = default!;
        }

    //}
}
