using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ChatBot.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service)
        {
            service.AddScoped<Repository>();

            return service;
        }
    }
}
