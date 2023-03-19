using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class EnergyEfficiencyInfo {

        public double? EpcScoreInKwhPerSquareMeterPerYear { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public EpcLabel? EpcLabel { get; set; }

        public string? EpcCertificateNumber { get; set; }

    }
}
