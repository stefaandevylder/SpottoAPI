using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class ParcelInfo {

        public decimal? ParcelDepthInMeters;

        public decimal? ParcelWidthInMeters;

        [JsonConverter(typeof(StringEnumConverter))]
        public FloodProneType? ParcelFloodProneType;

        public bool? ParcelHasPremptionRights;

        [JsonConverter(typeof(StringEnumConverter))]
        public SoilCertificateResultType? SoilCertificateResultType;

        public decimal? AmountOfTotalPlotSquareMeters;

        public decimal? AmountOfBuiltSquareMeters;

        public decimal? AmountOfGardenSquareMeters;

        public decimal? AmountOfTerraceSquareMeters;

        [JsonConverter(typeof(StringEnumConverter))]
        public OrientationType? OrientationFrontFacade;

        [JsonConverter(typeof(StringEnumConverter))]
        public OrientationType? OrientationGarden;

        [JsonConverter(typeof(StringEnumConverter))]
        public OrientationType? OrientationTerrace;

    }

}
