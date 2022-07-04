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
                ProductPhoto = "1d407629-87e5-4702-b9fc-e3b19de93570.jpg",
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
                ProductPhoto = "6b779a54-4cdc-4205-ba1f-9597c779a683.jpg",
                Price = (double)899.99
            });

            builder.HasData(new
            {
                Id = 3,
                Name = "მაიკლ კორსის პერანგი",
                Description = "ყველაზე ხარისხიანი პერანგი",
                SizeUsTypeId = (int)SizeUsTypeEnum.Xl,
                SizeEuTypeId = 43,
                ClothTypeId = (int)ClothTypeEnum.Shirt,
                ColorTypeId = (int)ColorTypeEnum.Brown,
                MaterialTypeId = (int)MaterialTypeEnum.Cotton,
                ProductPhoto = "0d293c69-ba4f-4ffc-b6b9-fa05316a02c5.jpg",
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
                ProductPhoto = "a47cd387-993a-4e23-b8a8-259d036cf37b.jpg",
                Price = (double)99.99
            });

            builder.HasData(new
            {
                Id = 5,
                Name = "ლამაზი პერანგი",
                Description = "ძალიან ლამაზი პერანგი",
                SizeUsTypeId = (int)SizeUsTypeEnum.M,
                SizeEuTypeId = 39,
                ClothTypeId = (int)ClothTypeEnum.Shirt,
                ColorTypeId = (int)ColorTypeEnum.Blue,
                MaterialTypeId = (int)MaterialTypeEnum.Cotton,
                ProductPhoto = "0d293c69-ba4f-4ffc-b6b9-fa05316a02c5.jpg",
                Price = (double)399.99
            });
        }
    }
}
