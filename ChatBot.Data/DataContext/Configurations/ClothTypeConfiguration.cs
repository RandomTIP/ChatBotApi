using ChatBot.Data.DTL;
using ChatBot.Data.DTL.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatBot.Data.DataContext.Configurations
{
    public class ClothTypeConfiguration : IEntityTypeConfiguration<ClothType>
    {
        public void Configure(EntityTypeBuilder<ClothType> builder)
        {
            var enumValues = typeof(ClothTypeEnum).GetEnumValues();

            foreach (var enumValue in enumValues)
            {
                builder.HasData(new {Id = (int) enumValue, Name = enumValue.ToString()});
            }
        }
    }
}
