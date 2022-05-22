using System.Text.Json.Serialization;
using ChatBot.Data.DTL.Enums;

namespace ChatBot.Data.BotEntityModels
{
    public class BotEntity
    {
        /// <summary>
        /// ენუმის ინგლისური მნიშვნელობა
        /// </summary>
        [JsonPropertyName("entity")]
        public string? Entity { get; set; }

        /// <summary>
        /// ქართული მნიშვნელობა
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
}
