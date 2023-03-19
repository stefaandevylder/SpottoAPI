using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class PermitInfo {

        [JsonConverter(typeof(StringEnumConverter))]
        public PermitType? PermitType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PermitType? SubdivisionPermitType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ConstructionOffenseType? ConstructionOffenseType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ConstructionOffenseSubpoenaType? ConstructionOffenseSubpoenaType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public AreaDesignationType? AreaDesignationType { get; set; }

    }

}
