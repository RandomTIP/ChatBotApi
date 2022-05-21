using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Data.Base;

namespace ChatBot.Data
{
    public class User : EntityBase
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int GenderTypeId { get; set; }
    }
}
