namespace WhatsTheWeather
{

    public class VisualCrossingData
    {
        public int queryCost { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string resolvedAddress { get; set; } = default!;
        public string address { get; set; } = default!;
        public string timezone { get; set; } = default!;
        public float tzoffset { get; set; }
        public string description { get; set; } = default!;
        public VisualCrossingWeatherDay[] days { get; set; } = default!;
    }

    public class VisualCrossingWeatherDay
    {
        public string datetime { get; set; } = default!;
        public int datetimeEpoch { get; set; }
        public float tempmax { get; set; }
        public float tempmin { get; set; }
        public float temp { get; set; }
        public float feelslikemax { get; set; }
        public float feelslikemin { get; set; }
        public float feelslike { get; set; }
        public float dew { get; set; }
        public float humidity { get; set; }
        public float precip { get; set; }
        public float precipprob { get; set; }
        public float precipcover { get; set; }
        public object preciptype { get; set; } = default!;
        public float snow { get; set; }
        public float snowdepth { get; set; }
        public float windgust { get; set; }
        public float windspeed { get; set; }
        public float winddir { get; set; }
        public float pressure { get; set; }
        public float cloudcover { get; set; }
        public float visibility { get; set; }
        public float solarradiation { get; set; }
        public float solarenergy { get; set; }
        public float uvindex { get; set; }
        public float severerisk { get; set; }
        public string sunrise { get; set; } = default!;
        public int sunriseEpoch { get; set; }
        public string sunset { get; set; } = default!;
        public int sunsetEpoch { get; set; }
        public float moonphase { get; set; }
        public string conditions { get; set; } = default!;
        public string description { get; set; } = default!;
        public string icon { get; set; } = default!;
        public object stations { get; set; } = default!;
        public string source { get; set; } = default!;
    }

}
