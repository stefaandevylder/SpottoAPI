namespace SpottoAPI.Models.Property {

    public class NewBuildProjectInfo {

        public string? ProjectUniqueReference { get; set; }

        public int? MinimumAvailableCountBedrooms { get; set; }

        public int? MaximumAvailableCountBedrooms { get; set; }

        public double? MinimumAvailablePrice { get; set; }

        public double? MaximumAvailablePrice { get; set; }

        public double? MinimumSquareMeters { get; set; }

        public double? MaximumSquareMeters { get; set; }

        public int? PercentageSold { get; set; }

    }

}
