namespace WhatsTheWeather
{
    //public class WeatherAPIData
    //{

        public class WeatherAPIData
        {
            public WeatherAPILocation location { get; set; } = default!;
            public WeatherAPICurrent current { get; set; } = default!;
        }

        public class WeatherAPILocation
        {
            public string name { get; set; } = default!;
            public string region { get; set; } = default!;
            public string country { get; set; } = default!;
            public float lat { get; set; }
            public float lon { get; set; }
            public string tz_id { get; set; } = default!;
            public int localtime_epoch { get; set; }
            public string localtime { get; set; }= default!;
        }

        public class WeatherAPICurrent
        {
            public int last_updated_epoch { get; set; }
            public string last_updated { get; set; } = default!;
            public float temp_c { get; set; }
            public float temp_f { get; set; }
            public int is_day { get; set; }
            public WeatherAPICondition condition { get; set; } = default!;
            public float wind_mph { get; set; }
            public float wind_kph { get; set; }
            public int wind_degree { get; set; }
            public string wind_dir { get; set; } = default!;
            public float pressure_mb { get; set; }
            public float pressure_in { get; set; }
            public float precip_mm { get; set; }
            public float precip_in { get; set; }
            public int humidity { get; set; }
            public int cloud { get; set; }
            public float feelslike_c { get; set; }
            public float feelslike_f { get; set; }
            public float vis_km { get; set; }
            public float vis_miles { get; set; }
            public float uv { get; set; }
            public float gust_mph { get; set; }
            public float gust_kph { get; set; }
        }

        public class WeatherAPICondition
        {
            public string text { get; set; } = default!;
            public string icon { get; set; } = default!;
            public int code { get; set; }
        }

    //}
}
