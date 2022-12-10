namespace WhatsTheWeather
{
    public class AccuWeatherData
    {
        public DateTime LocalObservationDateTime { get; set; }
        public int EpochTime { get; set; }
        public string WeatherText { get; set; } = string.Empty;
        public int WeatherIcon { get; set; }
        public bool HasPrecipitation { get; set; }
        public object PrecipitationType { get; set; } = default!;
        public bool IsDayTime { get; set; }
        public AccuWeatherDataTemperature Temperature { get; set; } = default!;
        public string MobileLink { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
    }

    public class AccuWeatherDataTemperature
    {
        public AccuWeatherDataMetric Metric { get; set; } = new AccuWeatherDataMetric();
        public AccuWeatherDataImperial Imperial { get; set; } = new AccuWeatherDataImperial();
    }

    public class AccuWeatherDataMetric
    {
        public float Value { get; set; }
        public string Unit { get; set; } = string.Empty;
        public int UnitType { get; set; }
    }

    public class AccuWeatherDataImperial
    {
        public float Value { get; set; }
        public string Unit { get; set; } = string.Empty;
        public int UnitType { get; set; }
    }

}



