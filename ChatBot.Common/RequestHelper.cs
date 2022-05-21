using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace ChatBot.Common
{
    public static class RequestHelper
    {
        public static async Task<TResponse?> SendBotParseRequest<TResponse>(this HttpClient client, string uri, string param)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(uri),
                Content = new StringContent(JsonSerializer.Serialize(new { text = param }), Encoding.UTF8,
                    MediaTypeNames.Application.Json),
                Method = HttpMethod.Post
            };

            var res = await client.SendAsync(request);
            var content = await res.Content.ReadAsStringAsync();
            TResponse? response = JsonSerializer.Deserialize<TResponse>(content);

            return response;
        }
    }

    public class BotResponse
    {
        public BotIntent intent { get; set; }
        public List<BotEntity> entities { get; set; }
    }

    public class BotIntent
    {
        public string name { get; set; }
    }

    public class BotEntity
    {
        public string entity { get; set; }
        public string value { get; set; }
    }
}