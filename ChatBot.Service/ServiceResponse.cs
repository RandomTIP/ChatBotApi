using ChatBot.Data.DTL;

namespace ChatBot.Service
{
    public class ServiceResponse
    {
        public string? ResponseMessage { get; set; }

        public List<Product>? Products { get; set; }
    }
}
