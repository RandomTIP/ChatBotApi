using ChatBot.Data.DTL;
using ChatBot.Data.DTL.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatBot.Data.DataContext.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new
            {
                Id = 1,
                Name = "მასიმო დუტის შარვალი",
                Description = "ყველაზე მაგარი ბრენდული შარვალი",
                SizeUsTypeId = (int) SizeUsTypeEnum.M,
                SizeEuTypeId = 39,
                ClothTypeId = (int) ClothTypeEnum.Pants,
                ColorTypeId = (int) ColorTypeEnum.Black,
                MaterialTypeId = (int) MaterialTypeEnum.Cotton,
                Price = (double) 399.99
            });

            builder.HasData(new
            {
                Id = 2,
                Name = "ზარას კაბა",
                Description = "ყველაზე ძერსკი კაბა",
                SizeUsTypeId = (int)SizeUsTypeEnum.S,
                SizeEuTypeId = 36,
                ClothTypeId = (int)ClothTypeEnum.Dress,
                ColorTypeId = (int)ColorTypeEnum.ForestGreen,
                MaterialTypeId = (int)MaterialTypeEnum.Kashmir,
                Price = (double)899.99
            });

            builder.HasData(new
            {
                Id = 3,
                Name = "Eco კეტები",
                Description = "ყველაზე ხარისხიანი კეტები",
                SizeUsTypeId = (int)SizeUsTypeEnum.Xl,
                SizeEuTypeId = 43,
                ClothTypeId = (int)ClothTypeEnum.Shoe,
                ColorTypeId = (int)ColorTypeEnum.SandyBrown,
                MaterialTypeId = (int)MaterialTypeEnum.Leather,
                Price = (double)299.99
            });

            builder.HasData(new
            {
                Id = 4,
                Name = "ლუი ვიტონის ქუდი",
                Description = "ყველაზე ლამაზი ქუდი",
                SizeUsTypeId = (int)SizeUsTypeEnum.L,
                SizeEuTypeId = 40,
                ClothTypeId = (int)ClothTypeEnum.Hat,
                ColorTypeId = (int)ColorTypeEnum.PaleVioletRed,
                MaterialTypeId = (int)MaterialTypeEnum.Satin,
                Price = (double)99.99
            });
        }
    }
}
