using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Data.Base;
#pragma warning disable CS8618

namespace ChatBot.Data
{
    public class MaterialType : EntityBase
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class ClothType: EntityBase
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public enum ClothTypeEnum
    {
        Pant,
        Dress,
        Shoe,
        Hat
    }

    public class ColorType : EntityBase
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class SizeEuType : EntityBase
    {
        public int Value { get; set; }
        public string? Description { get; set; }
    }

    public class SizeUsType : EntityBase
    {
        public string Value { get; set; }
        public string? Description { get; set; }
    }
}
