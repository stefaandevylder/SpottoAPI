using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SpottoAPI.Models.Transaction {

    public class SpottoTransaction {

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public TransactionType? Type { get; set; }

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public AvailabilityStatusType? AvailabilityStatusType { get; set; }

        public bool? HidePriceDetails { get; set; }

        public ContactInfo? ContactInfo { get; set; }

        public CurrentOccupationInfo? CurrentOccupationInfo { get; set; }

        public RentTypeInfo? RentTypeInfo { get; set; }

        public SaleTypeInfo? SaleTypeInfo { get; set; }

        //public AnnuityTypeInfo? AnnuityTypeInfo { get; set; }

    }

}
