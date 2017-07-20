using System.Runtime.Serialization;

namespace AlexaMessageBuilder.Enums
{
    public enum CardType
    {
        [EnumMember(Value = "Simple")]
        Simple,
        [EnumMember(Value = "Standard")]
        Standard
    }
}