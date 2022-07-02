using System.Net.Http.Headers;
using ChatBot.Common;
using ChatBot.Data;
using ChatBot.Data.BotEntityModels;
using ChatBot.Data.DTL;
using ChatBot.Service;
using Microsoft.AspNetCore.Mvc;

namespace ChatBot.Api.Controllers
{
    [ApiController]
    [Route("v1/Bot")]
    public class ChatBotController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ChatBotQueryService _chatBotQueryService;

        public ChatBotController(HttpClient httpClient, ChatBotQueryService chatBotQueryService)
        {
            _httpClient = httpClient;
            _chatBotQueryService = chatBotQueryService;
        }

        [HttpGet("ParseText")]
        public async Task<ServiceResponse?> RequestParse([FromQuery]string text, CancellationToken cancellationToken)
        {
            var botResponse = await _httpClient.SendBotParseRequest<BotResponse>("model/parse", text, cancellationToken);
            var queryResponse = _chatBotQueryService.GetList(botResponse);
            return queryResponse;
        }

        [HttpPost("image-upload")]
        public async Task Image([FromForm] IFormFile image, CancellationToken cancellationToken)
        {
            try
            {
                await using var imageContent = image.OpenReadStream();
                HttpContent fileStreamContent = new StreamContent(imageContent);
                fileStreamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                    { Name = image.Name, FileName = image.FileName };
                fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                using var formData = new MultipartFormDataContent();
                formData.Add(fileStreamContent);
                var request = new HttpRequestMessage(HttpMethod.Get, HttpConfiguration.ImageRecognitionRoute)
                {
                    Content = formData
                };

                var response = await _httpClient.SendAsync(request, cancellationToken);

                var res = await response.Content.ReadAsStringAsync(cancellationToken);
                var pp = res;
            }
            catch (Exception e)
            {
                e.GetType();
            }
        }

        //[HttpGet("SizeUsFromSizeEu")]
        //public SizeUsType GetSizeUsFromSizeEu([FromQuery] int sizeEu, CancellationToken cancellationToken)
        //{
        //    var sizeEuType = new SizeEuType() {Value = sizeEu};
        //    return new SizeUsType() {Value = sizeEuType.GetSizeUsValue() ?? throw new InvalidOperationException()};
        //}
    }
}
