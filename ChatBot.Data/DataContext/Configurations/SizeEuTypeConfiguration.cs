using ChatBot.Data.DTL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatBot.Data.DataContext.Configurations
{
    public class SizeEuTypeConfiguration : IEntityTypeConfiguration<SizeEuType>
    {
        public void Configure(EntityTypeBuilder<SizeEuType> builder)
        {
            var i = 32;
            while (i < 47)
            {
                builder.HasData(new {Id = (int) i, Value = (int) i});
                i++;
            }
        }
    }
}
