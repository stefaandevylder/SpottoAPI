using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace SpottoAPI.Models.Transaction {

    public class SpottoTransaction {

        [JsonConverter(typeof(StringEnumConverter))]
        public TransactionType? Type { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public AvailabilityStatusType? AvailabilityStatusType { get; set; }

        public bool? HidePriceDetails { get; set; }

        public ContactInfo? ContactInfo { get; set; }

        public CurrentOccupationInfo? CurrentOccupationInfo { get; set; }

        public RentTypeInfo? RentTypeInfo { get; set; }

        public SaleTypeInfo? SaleTypeInfo { get; set; }

        //public AnnuityTypeInfo? AnnuityTypeInfo { get; set; }

    }

}
