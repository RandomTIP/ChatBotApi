using Microsoft.Extensions.DependencyInjection;

namespace ChatBot.Service
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            service.AddScoped<ChatBotQueryService>();

            return service;
        }
    }
}
