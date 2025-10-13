namespace ShopTARgv24.Core.Dto
{
    public class AccuLocationRootDto
    {
        public Guid? Id { get; set; }
        public DateTime? LocalObservationDateTime { get; set; }
        public string? WeatherText { get; set; }

        public string?  WeatherIcon { get; set; }

        public bool? HasPrecipitation { get; set; }

        public string? PrecipitationType { get; set; }

        public bool? IsDayTime { get; set; }

        public class Temperature
        {
            public class Metric
            {
                public int? Value { get; set; }
                public string? Unit { get; set; }
                public int? UnitType { get; set; }

            }
        }

        public string? MobileLink { get; set; }

        public string? Link {  get; set; }

    }
}
