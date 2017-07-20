using AlexaMessageBuilder.Enums;
using Newtonsoft.Json;

namespace AlexaMessageBuilder.Models
{
    public class StandardCard : Card
    {
        public StandardCard(string title) : base(CardType.Standard, title)
        {

        }

        /// <summary>
        /// The text content for a Standard card.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// The image content for a Standard card (not required).
        /// </summary>
        [JsonProperty("image")]
        public CardImage Image { get; set; }
    }
}