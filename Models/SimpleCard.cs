using AlexaMessageBuilder.Enums;
using Newtonsoft.Json;

namespace AlexaMessageBuilder.Models
{
    public class SimpleCard : Card
    {
        public SimpleCard(string title) : base(CardType.Simple, title)
        {

        }

        /// <summary>
        /// The text content for a Simple card.
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}