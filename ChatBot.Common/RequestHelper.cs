using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using RestSharp;

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

        public static async Task<TResponse?> ImageRecognitionRequest<TResponse>(this RestClient client, IFormFile image,
            CancellationToken cancellationToken)
        {
            var request = new RestRequest() { Method = Method.Get };
            using var str = new MemoryStream();
            await image.CopyToAsync(str, cancellationToken);
            var arr = str.ToArray();
            request.AddFile("files", arr, image.FileName, image.ContentType);
            var response = await client.ExecuteAsync(request, cancellationToken);
            TResponse? res = default;
            try
            {
                res = JsonSerializer.Deserialize<TResponse>(response.Content);
            }
            catch (Exception e)
            {
                e.GetType();
            }

            return res;
        }
    }
}