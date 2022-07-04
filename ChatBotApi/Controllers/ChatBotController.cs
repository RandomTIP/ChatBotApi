using System.Net.Http.Headers;
using ChatBot.Common;
using ChatBot.Data;
using ChatBot.Data.BotEntityModels;
using ChatBot.Data.DTL;
using ChatBot.Service;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

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

        [HttpPost("Insert")]
        public async Task<int> InsertCloth([FromBody] Product product, CancellationToken cancellationToken = default)
        {
            return _chatBotQueryService.InsertProduct(product);
        }

        [HttpGet("ParseText")]
        public async Task<ServiceResponse?> RequestParse([FromQuery]string text, CancellationToken cancellationToken)
        {
            var botResponse = await _httpClient.SendBotParseRequest<BotResponse>("model/parse", text, cancellationToken);
            var queryResponse = _chatBotQueryService.GetList(botResponse);
            return queryResponse;
        }

        [HttpPost("image-upload")]
        public async Task<ServiceResponse> Image([FromForm] IFormFile image, CancellationToken cancellationToken)
        {
            var client = new RestClient("http://localhost:5050/files");
            var imageScores = await client.ImageRecognitionRequest<ImageScore>(image, cancellationToken);
            return _chatBotQueryService.RecognizeImage(imageScores);
        }
    }
}
