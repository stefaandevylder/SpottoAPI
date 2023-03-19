using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class ParcelInfo {

        public decimal? parcelDepthInMeters;

        public decimal? parcelWidthInMeters;

        [JsonConverter(typeof(StringEnumConverter))]
        public FloodProneType? parcelFloodProneType;

        public bool? parcelHasPremptionRights;

        [JsonConverter(typeof(StringEnumConverter))]
        public SoilCertificateResultType? soilCertificateResultType;

        public decimal? amountOfTotalPlotSquareMeters;

        public decimal? amountOfBuiltSquareMeters;

        public decimal? amountOfGardenSquareMeters;

        public decimal? amountOfTerraceSquareMeters;

        [JsonConverter(typeof(StringEnumConverter))]
        public OrientationType? orientationFrontFacade;

        [JsonConverter(typeof(StringEnumConverter))]
        public OrientationType? orientationGarden;

        [JsonConverter(typeof(StringEnumConverter))]
        public OrientationType? orientationTerrace;

    }

}
