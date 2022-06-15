using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Data.Base;

namespace ChatBot.Data.DTL
{
    public class ProductPhoto : EntityBase
    {
        public string? Path { get; set; }
        public byte[]? Data { get; set; }
    }
}
