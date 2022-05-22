using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Data;
using ChatBot.Data.Base;
using ChatBot.Data.BotEntityModels;
using ChatBot.Data.DTL;
using ChatBot.Data.DTL.Enums;
using ChatBot.Data.QueryOptions;

namespace ChatBot.Service
{
    internal static class EntityToQueryConverter
    {
        public static QueryOption? InitializeQuery(this IEnumerable<BotEntity>? entities)
        {
            if (entities == null) return null;

            var result = new QueryOption();

            foreach (var entity in entities)
            {
                if(result.ClothTypeId == 0)
                    result.ClothTypeId = ((int?) entity.Entity?.GetValueFromName<ClothTypeEnum>()) ?? 0;
                if(result.ColorTypeId == 0)
                    result.ColorTypeId = ((int?)entity.Entity?.GetValueFromName<ColorTypeEnum>()) ?? 0;
                if(result.MaterialTypeId == 0)
                    result.MaterialTypeId = ((int?)entity.Entity?.GetValueFromName<MaterialTypeEnum>()) ?? 0;
            }

            return result;
        }
    }
}
