using CsvHelper.Configuration.Attributes;

namespace WhatsTheWeather
{

    //public class AccuWeatherLocationData
    //{
    //    public AccuWeatherLocationDataClass Property { get; set; }
    //}

    public class AccuWeatherLocationDataClass
    {
        public AccuWeatherLocationDataAdministrativearea AdministrativeArea { get; set; } = default!;
        public AccuWeatherLocationDataCountry Country { get; set; } = default!;
        public string[] DataSets { get; set; } = default!;
        public string EnglishName { get; set; } = string.Empty;
        public AccuWeatherLocationDataGeoposition GeoPosition { get; set; } = default!;
        public string Key { get; set; } = default!;
        public string LocalizedName { get; set; } = default!;
        public AccuWeatherLocationDataParentcity ParentCity { get; set; } = default!;
        public string PrimaryPostalCode { get; set; } = default!;
        public int Rank { get; set; }
        public AccuWeatherLocationDataRegion Region { get; set; } = default!;
        public AccuWeatherLocationDataSupplementaladminarea[] SupplementalAdminAreas { get; set; } = default!;
        public AccuWeatherLocationDataTimezone TimeZone { get; set; } = default!;
        public string Type { get; set; } = default!;
        public int Version { get; set; }
    }

    public class AccuWeatherLocationDataAdministrativearea
    {
        public string CountryID { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string EnglishType { get; set; } = string.Empty;
        public string ID { get; set; } = string.Empty;
        public int Level { get; set; }
        public string LocalizedName { get; set; } = string.Empty;
        public string LocalizedType { get; set; } = string.Empty;
    }

    public class AccuWeatherLocationDataCountry
    {
        public string EnglishName { get; set; } = string.Empty;
        public string ID { get; set; } = string.Empty;
        public string LocalizedName { get; set; } = string.Empty;
    }

    public class AccuWeatherLocationDataGeoposition
    {
        public AccuWeatherLocationDataElevation Elevation { get; set; } = default!;
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }

    public class AccuWeatherLocationDataElevation
    {
        public AccuWeatherLocationDataImperial Imperial { get; set; } = default!;
        public AccuWeatherLocationDataMetric Metric { get; set; } = default!;
    }

    public class AccuWeatherLocationDataImperial
    {
        public string Unit { get; set; } = string.Empty;
        public int UnitType { get; set; }
        public float Value { get; set; }
    }

    public class AccuWeatherLocationDataMetric
    {
        public string Unit { get; set; } = string.Empty;
        public int UnitType { get; set; }
        public float Value { get; set; }
    }

    public class AccuWeatherLocationDataParentcity
    {
        public string EnglishName { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public string LocalizedName { get; set; } = string.Empty;
    }

    public class AccuWeatherLocationDataRegion
    {
        public string EnglishName { get; set; } = string.Empty;
        public string ID { get; set; } = string.Empty;
        public string LocalizedName { get; set; } = string.Empty;
    }

    public class AccuWeatherLocationDataTimezone
    {
        public string Code { get; set; } = string.Empty;
        public float GmtOffset { get; set; }
        public bool IsDaylightSaving { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime NextOffsetChange { get; set; }
    }

    public class AccuWeatherLocationDataSupplementaladminarea
    {
        public string EnglishName { get; set; } = string.Empty;
        public int Level { get; set; }
        public string LocalizedName { get; set; } = string.Empty;
    }

}
