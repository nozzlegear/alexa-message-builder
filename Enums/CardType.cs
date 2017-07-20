using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AlexaMessageBuilder.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardType
    {
        [EnumMember(Value = "simple")]
        Simple,
        [EnumMember(Value = "standard")]
        Standard
    }
}