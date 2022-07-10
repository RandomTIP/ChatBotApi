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
                ColorTypeId = (int)ColorTypeEnum.Blue,
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


            builder.HasData(new
            {
                Id = 6,
                Name = "ვარდისფერი კაშმირის კაბა",
                Description = "ყველაზე ლამაზი კაბა",
                SizeUsTypeId = (int)SizeUsTypeEnum.S,
                SizeEuTypeId = 36,
                ClothTypeId = (int)ClothTypeEnum.Dress,
                ColorTypeId = (int)ColorTypeEnum.Pink,
                MaterialTypeId = (int)MaterialTypeEnum.Kashmir,
                ProductPhoto = "5cb8b297-de57-4ee2-984a-7c9cdc748558.jpg",
                Price = (double)99.99
            });


            builder.HasData(new
            {
                Id = 7,
                Name = "ლურჯი ბამბის კაბა",
                Description = "ყველაზე ლამაზი კაბა",
                SizeUsTypeId = (int)SizeUsTypeEnum.S,
                SizeEuTypeId = 36,
                ClothTypeId = (int)ClothTypeEnum.Dress,
                ColorTypeId = (int)ColorTypeEnum.Blue,
                MaterialTypeId = (int)MaterialTypeEnum.Cotton,
                ProductPhoto = "6e143162-9472-43c3-8db1-04eeea838ae8.jpg",
                Price = (double)29.99
            });

            builder.HasData(new
            {
                Id = 8,
                Name = "მუქი ლურჯი ბამბის კაბა",
                Description = "მოდური კაბა",
                SizeUsTypeId = (int)SizeUsTypeEnum.S,
                SizeEuTypeId = 36,
                ClothTypeId = (int)ClothTypeEnum.Dress,
                ColorTypeId = (int)ColorTypeEnum.PaleVioletRed,
                MaterialTypeId = (int)MaterialTypeEnum.Cotton,
                ProductPhoto = "6eaff8d0-517f-4fad-ad54-4249b8c53ff9.jpg",
                Price = (double)29.99
            });

            builder.HasData(new
            {
                Id = 9,
                Name = "თეთრი კაბა",
                Description = "მოდური კაბა",
                SizeUsTypeId = (int)SizeUsTypeEnum.S,
                SizeEuTypeId = 36,
                ClothTypeId = (int)ClothTypeEnum.Dress,
                ColorTypeId = (int)ColorTypeEnum.White,
                MaterialTypeId = (int)MaterialTypeEnum.Kashmir,
                ProductPhoto = "7fc487f9-81a1-4285-aef9-45574cc8adce.jpg",
                Price = (double)59.99
            });

            builder.HasData(new
            {
                Id = 10,
                Name = "მუქი ლურჯი შარვალი",
                Description = "შესანიშნავი შარვალი",
                SizeUsTypeId = (int)SizeUsTypeEnum.S,
                SizeEuTypeId = 36,
                ClothTypeId = (int)ClothTypeEnum.Pants,
                ColorTypeId = (int)ColorTypeEnum.Blue,
                MaterialTypeId = (int)MaterialTypeEnum.Leather,
                ProductPhoto = "0ccc318a-7d69-4d7f-a442-aac1f88bc453.jpg",
                Price = (double)159.99
            });


            builder.HasData(new
            {
                Id = 11,
                Name = "ტყავის ლურჯი შარვალი",
                Description = "შესანიშნავი შარვალი",
                SizeUsTypeId = (int)SizeUsTypeEnum.S,
                SizeEuTypeId = 36,
                ClothTypeId = (int)ClothTypeEnum.Pants,
                ColorTypeId = (int)ColorTypeEnum.Blue,
                MaterialTypeId = (int)MaterialTypeEnum.Leather,
                ProductPhoto = "8acbe013-6f78-400b-a9e6-66144cf8574d.jpg",
                Price = (double)129.99
            });

            builder.HasData(new
            {
                Id = 12,
                Name = "აბრეშუმის წითელი შარვალი",
                Description = "შესანიშნავი შარვალი",
                SizeUsTypeId = (int)SizeUsTypeEnum.S,
                SizeEuTypeId = 35,
                ClothTypeId = (int)ClothTypeEnum.Pants,
                ColorTypeId = (int)ColorTypeEnum.Red,
                MaterialTypeId = (int)MaterialTypeEnum.Silk,
                ProductPhoto = "119518b0-abfc-49a1-88dc-016f2dbd17ff.jpg",
                Price = (double)2259.99
            });

            builder.HasData(new
            {
                Id = 13,
                Name = "აბრეშუმის ყვითელი შარვალი",
                Description = "ყველაზე მოდური შარვალი",
                SizeUsTypeId = (int)SizeUsTypeEnum.S,
                SizeEuTypeId = 36,
                ClothTypeId = (int)ClothTypeEnum.Pants,
                ColorTypeId = (int)ColorTypeEnum.Yellow,
                MaterialTypeId = (int)MaterialTypeEnum.Silk,
                ProductPhoto = "300963e8-f469-471c-a7dd-9eed99ddad4f.jpg",
                Price = (double)1259.99
            });

            builder.HasData(new
            {
                Id = 14,
                Name = "წითელი ქუდი",
                Description = "ყველაზე მოდური შარვალი",
                SizeUsTypeId = (int)SizeUsTypeEnum.M,
                SizeEuTypeId = 39,
                ClothTypeId = (int)ClothTypeEnum.Hat,
                ColorTypeId = (int)ColorTypeEnum.Red,
                MaterialTypeId = (int)MaterialTypeEnum.Leather,
                ProductPhoto = "1febd681-151b-4c8c-baff-ddc52d16c6c0.jpg",
                Price = (double)259.99
            });   


            builder.HasData(new
            {
                Id = 15,
                Name = "ნაიკის ქუდი",
                Description = "მაღალი ხარისხის წითელი ქუდი",
                SizeUsTypeId = (int)SizeUsTypeEnum.M,
                SizeEuTypeId = 39,
                ClothTypeId = (int)ClothTypeEnum.Hat,
                ColorTypeId = (int)ColorTypeEnum.Red,
                MaterialTypeId = (int)MaterialTypeEnum.Leather,
                ProductPhoto = "2f96b4e8-3af7-4b3f-9488-69a51df7a917.jpg",
                Price = (double)259.99
            });
        }
    }
}