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

        //[HttpGet("SizeUsFromSizeEu")]
        //public SizeUsType GetSizeUsFromSizeEu([FromQuery] int sizeEu, CancellationToken cancellationToken)
        //{
        //    var sizeEuType = new SizeEuType() {Value = sizeEu};
        //    return new SizeUsType() {Value = sizeEuType.GetSizeUsValue() ?? throw new InvalidOperationException()};
        //}
    }
}
