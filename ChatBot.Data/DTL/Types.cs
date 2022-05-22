using System.Drawing;
using ChatBot.Data.Base;

#pragma warning disable CS8618

namespace ChatBot.Data.DTL
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
