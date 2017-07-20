using System.Runtime.Serialization;

namespace AlexaMessageBuilder.Enums
{
    public enum SpeechType
    {
        [EnumMember(Value = "text")]
        PlainText,
        [EnumMember(Value = "ssml")]
        SSML
    }
}