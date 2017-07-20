using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaMessageBuilder.Models
{
    public class Message
    {
        [JsonProperty("version")]
        public string Version { get; set; } = "1.0.0";

        [JsonProperty("response")]
        public Response Response { get; set; } = new Response();

        public Dictionary<string, object> SessionAttributes;
    }
}