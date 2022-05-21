using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Data.Base;

namespace ChatBot.Data
{
    public class UserCart : EntityBase
    {
        public int UserId { get; set; }
        public User? User { get; set; }

        public List<Product>? Product { get; set; }

        public double Sum { get; set; }
    }
}
