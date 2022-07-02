using ChatBot.Data.DTL;
using Microsoft.EntityFrameworkCore;

namespace ChatBot.Data.DataContext
{
    public class ChatBotContext : DbContext
    {
        public ChatBotContext(DbContextOptions<ChatBotContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCart> UserCarts { get; set; }
        public DbSet<ClothType> ClothTypes { get; set; }
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<ColorType> ColorTypes { get; set; }
        public DbSet<SizeEuType> SizeEuTypes { get; set; }
        public DbSet<SizeUsType> SizeUsTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
