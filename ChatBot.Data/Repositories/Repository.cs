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
                .Include(x => x.ProductPhoto)
                .ToList();

            if (option.ColorTypeId is not null or 0)
                list = list.Where(x => x.ColorTypeId == option.ColorTypeId).ToList();

            if (option.SizeEuTypeId is not null or 0 || option.SizeUsTypeId is not null or 0)
                list = list.Where(x => x.SizeEuTypeId == option.SizeEuTypeId || x.SizeUsTypeId == option.SizeUsTypeId).ToList();

            if (option.MaterialTypeId is not null or 0)
                list = list.Where(x => x.MaterialTypeId == option.MaterialTypeId).ToList();

            return list.ToList();
        }
    }
}
