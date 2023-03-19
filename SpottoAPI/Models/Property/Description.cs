using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SpottoAPI.Models.Property {

    public class Description {

        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public DescriptionType? Type { get; set; }

        public string? LanguageCode { get; set; }

        public string? Value { get; set; }

        public Description(DescriptionType type, string languageCode, string value) {
            Type = type;
            LanguageCode = languageCode;
            Value = value;
        }

    }

}
