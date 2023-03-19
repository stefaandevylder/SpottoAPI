using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class ParcelInfo {

        public decimal? ParcelDepthInMeters;

        public decimal? ParcelWidthInMeters;

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public FloodProneType? ParcelFloodProneType;

        public bool? ParcelHasPremptionRights;

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public SoilCertificateResultType? SoilCertificateResultType;

        public decimal? AmountOfTotalPlotSquareMeters;

        public decimal? AmountOfBuiltSquareMeters;

        public decimal? AmountOfGardenSquareMeters;

        public decimal? AmountOfTerraceSquareMeters;

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public OrientationType? OrientationFrontFacade;

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public OrientationType? OrientationGarden;

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public OrientationType? OrientationTerrace;

    }

}
