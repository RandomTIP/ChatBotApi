using ChatBot.Data.DTL;
using ChatBot.Data.DTL.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatBot.Data.DataContext.Configurations
{
    public class SizeUsTypeConfiguration : IEntityTypeConfiguration<SizeUsType>
    {
        public void Configure(EntityTypeBuilder<SizeUsType> builder)
        {
            var enumValues = typeof(SizeUsTypeEnum).GetEnumValues();

            foreach (var enumValue in enumValues)
            {
                builder.HasData(new { Id = (int)enumValue, Value = enumValue.ToString() });
            }
        }
    }
}
