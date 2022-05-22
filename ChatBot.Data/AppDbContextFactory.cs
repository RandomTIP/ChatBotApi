using ChatBot.Data.DataContext;
using Microsoft.EntityFrameworkCore;

namespace ChatBot.Data
{
    public class AppDbContextFactory
    {
        public ChatBotContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ChatBotContext>();
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=ChatBot;Integrated Security=False;Persist Security Info=True;MultipleActiveResultSets=True;App=ChatBot.Api;");

            return new ChatBotContext(optionsBuilder.Options);
        }
    }
}
