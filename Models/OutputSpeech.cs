using AlexaMessageBuilder.Enums;
using Newtonsoft.Json;

namespace AlexaMessageBuilder.Models
{
    public class OutputSpeech
    {
        public OutputSpeech(SpeechType speechType)
        {
            Type = speechType;
        }

        [JsonProperty("type")]
        public SpeechType Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("ssml")]
        public string SSML { get; set; }
    }
}