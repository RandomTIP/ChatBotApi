using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace ChatBot.Common
{
    public static class RequestHelper
    {
        public static async Task<TResponse?> SendBotParseRequest<TResponse>(this HttpClient client, string uri, string param, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri($"{HttpConfiguration.HttpRouteRoot}{uri}"),
                Content = new StringContent(JsonSerializer.Serialize(new { text = param }), Encoding.UTF8,
                    MediaTypeNames.Application.Json),
                Method = HttpMethod.Post
            };

            var res = await client.SendAsync(request, cancellationToken);
            var content = await res.Content.ReadAsStringAsync(cancellationToken);
            TResponse? response = JsonSerializer.Deserialize<TResponse>(content);

            return response;
        }
    }
}