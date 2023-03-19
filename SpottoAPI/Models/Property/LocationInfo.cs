namespace SpottoAPI.Models.Property {

    public class LocationInfo {

        public bool? HideLocation { get; set; }

        public Coordinates? Coordinates { get; set; }

        public AddressInfo? Address { get; set; }

        public List<string>? LocationFeatures { get; set; }
    }

    public class Coordinates {

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

    }

    public class AddressInfo {

        public string? Street { get; set; }

        public string? StreetNumber { get; set; }

        public string? StreetBox { get; set; }

        public string? MunicipalityPostalCode { get; set; }

        public string? MunicipalityName { get; set; }

        public string? SubMunicipalityPostalCode { get; set; }

        public string? SubMunicipalityName { get; set; }

        public string? RegionCode { get; set; }

        public string? TwoLetterIsoCountryCode { get; set; }

    }
}
