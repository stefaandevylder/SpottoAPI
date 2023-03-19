using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class ConstructionInfo {

        [JsonConverter(typeof(StringEnumConverter))]
        public ConditionStateType ConditionStateType { get; set; }

        public bool? IsProtectedProperty { get; set; }

        public bool? HasAsBuiltCertificate { get; set; }

        public int? RenovationYear { get; set; }

        public int? ConstructionYear { get; set; }

        public int? UnitFloorLevel { get; set; }

        public int? FacadeCount { get; set; }

        public double? FacadeWidthInMeters { get; set; }

        public double? AmountOfIndoorSquareMeters { get; set; }

        public int? AmountOfGarages { get; set; }

        public int? AmountOfParkingSpots { get; set; }

        public int? AmountOfFloors { get; set; }

        public int? AmountOfLivings { get; set; }

        public int? AmountOfKitchens { get; set; }

        public int? AmountOfBedrooms { get; set; }

        public int? AmountOfBathrooms { get; set; }

        public int? AmountOfShowerRooms { get; set; }

        public int? AmountOfToilets { get; set; }

        public int? AmountOfOffices { get; set; }

        public int? AmountOfBasements { get; set; }

        public int? AmountOfAttics { get; set; }

        public int? AmountOfStorageRooms { get; set; }

        public List<SpaceDetail>? SpaceDetails { get; set; }

        //public OutfittingInfo OutfittingInfo { get; set; }

    }

}
