using ChatBot.Common;
using Microsoft.AspNetCore.Mvc;

namespace ChatBot.Api.Controllers
{
    [ApiController]
    [Route("v1/Bot")]
    public class ChatBotController : Controller
    {
        private readonly HttpClient _httpClient;

        public ChatBotController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("ParseText")]
        public async Task<BotResponse?> RequestParse([FromQuery]string text, CancellationToken cancellationToken)
        {
            var res = await _httpClient.SendBotParseRequest<BotResponse>("http://localhost:8080/model/parse", text);
            return res;
        }
    }
}
