using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SpottoAPI.Models.Transaction {

    public class SaleTypeInfo {

        public double? Price { get; set; }

        public double? PriceTo { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public PriceType? PriceType { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public TaxSystemType? TaxSystemType { get; set; }

        public double? TaxPercentageAmount { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public ProcedureType? ProcedureType { get; set; }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? AvailableFromDate { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public AvailableFromEventType? AvailableFromEventType { get; set; }

    }

}
