using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Data.Base;
#pragma warning disable CS8618

namespace ChatBot.Data
{
    public sealed class Product : EntityBase
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public int SizeEuTypeId { get; set; }
        public SizeEuType? SizeEuType { get; set; }

        public int SizeUsTypeId { get; set; }
        public SizeUsType? SizeUsType { get; set; }

        public int ClothTypeId { get; set; }
        public ClothType? ClothType { get; set; }

        public int MaterialTypeId { get; set; }
        public MaterialType? MaterialType { get; set; }

        public int ColorTypeId { get; set; }
        public ColorType? ColorType { get; set; }

        public int UserCartId { get; set; }
        public UserCart? UserCart { get; set; }

        public double Price { get; set; }
    }
}
