using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace SpottoAPI.Models.Transaction {

    public class SaleTypeInfo {

        public double? Price { get; set; }

        public double? PriceTo { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PriceType? PriceType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TaxSystemType? TaxSystemType { get; set; }

        public double? TaxPercentageAmount { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ProcedureType? ProcedureType { get; set; }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? AvailableFromDate { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public AvailableFromEventType? AvailableFromEventType { get; set; }

    }

}
