using ChatBot.Data.DTL;
using ChatBot.Data.DTL.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatBot.Data.DataContext.Configurations
{
    public class ColorTypeConfiguration : IEntityTypeConfiguration<ColorType>
    {
        public void Configure(EntityTypeBuilder<ColorType> builder)
        {
            var enumValues = typeof(ColorTypeEnum).GetEnumValues();

            foreach (var enumValue in enumValues)
            {
                builder.HasData(new { Id = (int)enumValue, Name = enumValue.ToString() });
            }
        }
    }
}
