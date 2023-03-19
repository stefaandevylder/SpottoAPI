using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class SpottoProperty {

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public PropertyType? Type { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public PropertySubType? SubType { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public PropertyPorposeType? PurposeType { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public PropertyNewBuildType? NewBuildType { get; set; }

        public PropertyIdentifiers? PropertyIdentifiers { get; set; }

        public FiscalInfo? FiscalInfo { get; set; }

        public EnergyEfficiencyInfo? EnergyEfficiencyInfo { get; set; }

        public PermitInfo? PermitInfo { get; set; }

        public FeatureIndicationInfo? FeatureIndicationInfo { get; set; }

        public ParcelInfo? ParcelInfo { get; set; }

        public ConstructionInfo? ConstructionInfo { get; set; }

        public ApartmentBlockInfo? ApartmentBlockInfo { get; set; }

        public NewBuildProjectInfo? NewBuildProjectInfo { get; set; }

        public List<Description>? Descriptions { get; set; }

        public LocationInfo? Location { get; set; }
    }

}
