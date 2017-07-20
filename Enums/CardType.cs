using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AlexaMessageBuilder.Enums
{
    public enum CardType
    {
        [EnumMember(Value = "simple"), JsonProperty("simple")]
        Simple,
        [EnumMember(Value = "standard"), JsonProperty("standard")]
        Standard
    }
}