using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SpottoAPI.Models.Transaction {

    public class RentalUnitInfo {

        public double? RentalPrice { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public RentalPricePeriod? RentalPricePeriod { get; set; }

        public int? RentalPricePeriodDuration { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public RentalContractType? RentalContractType { get; set; }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? RentalContractExpiry { get; set; }

    }
}
