using System.Text.Json.Serialization;

namespace ChatBot.Data.BotEntityModels
{
    public class BotResponse
    {
        [JsonPropertyName("intent")]
        public BotIntent? Intent { get; set; }
        [JsonPropertyName("entities")]
        public List<BotEntity>? Entities { get; set; }

    }
}
