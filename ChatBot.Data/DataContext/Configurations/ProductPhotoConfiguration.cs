using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Data.DTL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatBot.Data.DataContext.Configurations
{
    public class ProductPhotoConfiguration : IEntityTypeConfiguration<ProductPhoto>
    {
        public void Configure(EntityTypeBuilder<ProductPhoto> builder)
        {
            //კაბა
            builder.HasData(new
            {
                Id = 1,
                Path = "C:\\Users\\ramazi\\Desktop\\photos\\dress.jpg"
            });

            //ქუდი
            builder.HasData(new
            {
                Id = 2,
                Path = "C:\\Users\\ramazi\\Desktop\\photos\\hat.jpg"
            });

            //შარვალი
            builder.HasData(new
            {
                Id = 3,
                Path = "C:\\Users\\ramazi\\Desktop\\photos\\pants.jpg"
            });

            //ფეხსაცმელი
            builder.HasData(new
            {
                Id = 4,
                Path = "C:\\Users\\ramazi\\Desktop\\photos\\shoes.jpg"
            });
        }
    }
}
