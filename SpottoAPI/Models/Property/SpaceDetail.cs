using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class SpaceDetail {

        [JsonConverter(typeof(StringEnumConverter))]
        public SpaceType? SpaceType { get; set; }

        public double? SquareMeters { get; set; }

        public int? WidthInMeters { get; set; }

        public int? LengthInMeters { get; set; }

    }

}
