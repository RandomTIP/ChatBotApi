using ChatBot.Data.DTL;
using ChatBot.Data.DTL.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatBot.Data.DataContext.Configurations
{
    public class MaterialTypeConfiguration : IEntityTypeConfiguration<MaterialType>
    {
        public void Configure(EntityTypeBuilder<MaterialType> builder)
        {
            var enumValues = typeof(MaterialTypeEnum).GetEnumValues();

            foreach (var enumValue in enumValues)
            {
                builder.HasData(new { Id = (int)enumValue, Name = enumValue.ToString() });
            }
        }
    }
}
