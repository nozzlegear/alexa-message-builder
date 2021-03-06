using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AlexaMessageBuilder.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SpeechType
    {
        [EnumMember(Value = "PlainText")]
        PlainText,
        [EnumMember(Value = "SSML")]
        SSML
    }
}