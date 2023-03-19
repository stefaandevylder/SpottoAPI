using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class SpaceDetail {

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public SpaceType? SpaceType { get; set; }

        public double? SquareMeters { get; set; }

        public int? WidthInMeters { get; set; }

        public int? LengthInMeters { get; set; }

    }

}
