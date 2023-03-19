using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class EnergyEfficiencyInfo {

        public double? EpcScoreInKwhPerSquareMeterPerYear { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public EpcLabel? EpcLabel { get; set; }

        public string? EpcCertificateNumber { get; set; }

    }
}
