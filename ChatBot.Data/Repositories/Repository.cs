using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Data.BotEntityModels;
using ChatBot.Data.DataContext;
using ChatBot.Data.DTL;
using ChatBot.Data.QueryOptions;
using Microsoft.EntityFrameworkCore.Infrastructure;

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

            if (option.ClothTypeId == null) return null;

            var list = _chatBotContext.Products.Where(x => x.ClothTypeId == option.ClothTypeId);

            if (option.ColorTypeId == null) return list.ToList();

            list = list.Where(x => x.ColorTypeId == option.ColorTypeId);

            if (option.MaterialTypeId == null) return list.ToList();

            list = list.Where(x => x.MaterialTypeId == option.MaterialTypeId);

            if(option.SizeEuTypeId == null && option.SizeUsTypeId == null) return list.ToList();

            list = list.Where(x => x.SizeEuTypeId == option.SizeEuTypeId || x.SizeUsTypeId == option.SizeUsTypeId);

            return list.ToList();
        }
    }
}
