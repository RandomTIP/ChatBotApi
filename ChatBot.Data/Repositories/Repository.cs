using ChatBot.Data.DataContext;
using ChatBot.Data.DTL;
using ChatBot.Data.QueryOptions;
using Microsoft.EntityFrameworkCore;

namespace ChatBot.Data.Repositories
{
    public class Repository
    {
        private readonly ChatBotContext _chatBotContext;

        public Repository(ChatBotContext chatBotContext)
        {
            _chatBotContext = chatBotContext;
        }

        public int Insert(Product product)
        {
            var res = _chatBotContext.Products.Add(product);
            return res.Entity.Id;
        }

        public List<Product>? GetProductList(QueryOption? option)
        {
            if (option == null) return null;

            if (option.ClothTypeId is null or 0) return null;

            var list = _chatBotContext.Products
                .Where(x => x.ClothTypeId == option.ClothTypeId)
                .Include(x => x.SizeUsType)
                .Include(x => x.ClothType)
                .Include(x => x.SizeEuType)
                .Include(x => x.MaterialType)
                .Include(x => x.ColorType)
                .ToList();

            if (option.ColorTypeId is > 0)
                list = list.Where(x => x.ColorTypeId == option.ColorTypeId).ToList();

            if (option.SizeEuTypeId is > 0 || option.SizeUsTypeId is > 0)
                list = list.Where(x => x.SizeEuTypeId == option.SizeEuTypeId || x.SizeUsTypeId == option.SizeUsTypeId).ToList();

            if (option.MaterialTypeId is > 0)
                list = list.Where(x => x.MaterialTypeId == option.MaterialTypeId).ToList();

            return list.ToList();
        }

        public Product? GetProductByPhoto(string? photo)
        {
            return photo == null ? null : _chatBotContext.Products.FirstOrDefault(x => x.ProductPhoto == photo);
        }
    }
}
