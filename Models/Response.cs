using Newtonsoft.Json;

namespace AlexaMessageBuilder.Models
{
    public class Response
    {
        [JsonProperty("shouldEndSession")]
        public bool ShouldEndSession { get; set; } = true;

        [JsonProperty("reprompt")]
        public Response Reprompt { get; set; }

        [JsonProperty("outputSpeech")]
        public OutputSpeech OutputSpeech { get; set; }

        [JsonProperty("ssml")]
        public string SSML { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// An optional Card to display in the Alexa app or on an Alexa Show device.
        /// </summary>
        [JsonProperty("card")]
        public Card Card { get; set; }
    }
}