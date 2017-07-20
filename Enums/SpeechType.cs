using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AlexaMessageBuilder.Enums
{
    public enum SpeechType
    {
        [EnumMember(Value = "text"), JsonProperty("text")]
        PlainText,
        [EnumMember(Value = "ssml"), JsonProperty("ssml")]
        SSML
    }
}