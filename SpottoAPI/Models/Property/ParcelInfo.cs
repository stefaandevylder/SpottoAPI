using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class ParcelInfo {

        public int? ParcelDepthInMeters;

        public int? ParcelWidthInMeters;

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public FloodProneType? ParcelFloodProneType;

        public bool? ParcelHasPremptionRights;

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public SoilCertificateResultType? SoilCertificateResultType;

        public int? AmountOfTotalPlotSquareMeters;

        public int? AmountOfBuiltSquareMeters;

        public int? AmountOfGardenSquareMeters;

        public int? AmountOfTerraceSquareMeters;

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public OrientationType? OrientationFrontFacade;

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public OrientationType? OrientationGarden;

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public OrientationType? OrientationTerrace;

    }

}
