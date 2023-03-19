using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace SpottoAPI.Models.Transaction {

    public class RentalUnitInfo {

        public double? RentalPrice { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public RentalPricePeriod? RentalPricePeriod { get; set; }

        public int? RentalPricePeriodDuration { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public RentalContractType? RentalContractType { get; set; }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? RentalContractExpiry { get; set; }

    }
}
