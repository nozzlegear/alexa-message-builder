namespace AlexaMessageBuilder.Models
{
    public class CardImage
    {
        public CardImage(string smallImageUrl, string largeImageUrl)
        {
            SmallImageUrl = smallImageUrl;
            LargeImageUrl = largeImageUrl;
        }

        public string SmallImageUrl { get; set; }

        public string LargeImageUrl { get; set; }
    }
}