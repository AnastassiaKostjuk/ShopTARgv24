﻿namespace ShopTARgv24.Core.Dto
{
    public class AccuCityCodeRootDto
    {
        public int? Version { get; set; }
        public string? Key { get; set; }
        public string? Type { get; set; }
        public int? Rank { get; set; }
        public string? LocalizedName { get; set; }
        public string? EnglishName { get; set; }
        public string? PrimaryPostalCode { get; set; }

        public RegionCountryValueDto? Region { get; set; } 
        public RegionCountryValueDto? Country { get; set; } 

        public AdministrativeAreaDto? AdministrativeArea { get; set; }
        public TimeZoneDto? TimeZone { get; set; }
        public GeoPosition? GeoPosition { get; set; }
        public bool? IsAlias { get; set; }
        public List<SupplementalAdminAreasDto>? SupplementalAdminAreas { get; set; }
        public List<string>? DataSets { get; set; } 
    }

    public class RegionCountryValueDto
    {
        public string? ID { get; set; }
        public string? LocalizedName { get; set; }
        public string? EnglishName { get; set; }
    }

    public class AdministrativeAreaDto
    {
        public string? ID { get; set; }
        public string? LocalizedName { get; set; }
        public string? EnglishName { get; set; }
        public int? Level { get; set; }
        public string? LocalizedType { get; set; }
        public string? EnglishType { get; set; }
        public string? CountryID { get; set; }
    }

    public class TimeZoneDto
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int? GmtOffset { get; set; }
        public bool? IsDaylightSaving { get; set; }
        public DateTime? NextOffsetChange { get; set; }
    }

    public class GeoPosition
    {
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public ElevationDto? Elevation { get; set; } 
    }

    public class ElevationDto
    {
        public ElevationValueDto? Metric { get; set; }
        public ElevationValueDto? Imperial { get; set; }
    }

    public class ElevationValueDto
    {
        public double? Value { get; set; }
        public string? Unit { get; set; }
        public int? UnitType { get; set; }
    }

    public class SupplementalAdminAreasDto
    {
        public int? Level { get; set; }
        public string? LocalizedName { get; set; }
        public string? EnglishName { get; set; }
    }
}
