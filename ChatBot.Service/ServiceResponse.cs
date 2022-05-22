using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Data.DTL;

namespace ChatBot.Service
{
    public class ServiceResponse
    {
        public string? ResponseMessage { get; set; }

        public List<Product>? Products { get; set; }
    }
}
