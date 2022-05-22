using ChatBot.Data;
using ChatBot.Data.BotEntityModels;
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
                if(result.ClothTypeId is null or 0)
                    result.ClothTypeId = ((int?) entity.Entity?.GetValueFromName<ClothTypeEnum>()) ?? 0;
                if(result.ColorTypeId is null or 0)
                    result.ColorTypeId = ((int?)entity.Entity?.GetValueFromName<ColorTypeEnum>()) ?? 0;
                if(result.MaterialTypeId is null or 0)
                    result.MaterialTypeId = ((int?)entity.Entity?.GetValueFromName<MaterialTypeEnum>()) ?? 0;
            }

            return result;
        }
    }
}
