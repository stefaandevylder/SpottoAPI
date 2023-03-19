using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class Description {

        [JsonConverter(typeof(StringEnumConverter))]
        public DescriptionType? Type { get; set; }

        public string? LanguageCode { get; set; }

        public string? Value { get; set; }

    }

}
