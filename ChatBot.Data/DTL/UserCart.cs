using ChatBot.Data.Base;

namespace ChatBot.Data.DTL
{
    public class UserCart : EntityBase
    {
        public int UserId { get; set; }
        public User? User { get; set; }

        public List<Product>? Product { get; set; }

        public double Sum { get; set; }
    }
}
