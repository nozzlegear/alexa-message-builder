using AlexaMessageBuilder.Enums;
using Newtonsoft.Json;

namespace AlexaMessageBuilder.Models
{
    public abstract class Card
    {
        public Card(CardType type, string title)
        {
            Type = type;
            Title = title;
        }

        [JsonProperty("type")]
        public CardType Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}