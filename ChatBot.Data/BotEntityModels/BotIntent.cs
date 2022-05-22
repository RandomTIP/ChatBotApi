using System.Text.Json.Serialization;

namespace ChatBot.Data.BotEntityModels
{
    public class BotIntent
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
