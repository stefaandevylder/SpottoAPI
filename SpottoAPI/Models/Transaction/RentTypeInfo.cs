using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SpottoAPI.Models.Transaction {

    public class RentTypeInfo {

        public double? Price { get; set; }

        public double? PriceTo { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public PriceType? PriceType { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public RentalPricePeriod? PricePeriod { get; set; }

        public int? PricePeriodDuration { get; set; }

        public double? CostAmount { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public RentalCostPeriod? CostPeriod { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public RentalCostType? CostType { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public RentalCostInclude? CostIncludes { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public RentalContractType? ContractType { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public RentalContractPeriod? ContractPeriod { get; set; }

        public int? ContractPeriodDuration { get; set; }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? AvailableFrom { get; set; }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? AvailableTo { get; set; }

        public List<object>? ExtraInfo { get; set; }

    }

}
