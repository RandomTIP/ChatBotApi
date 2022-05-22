using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Data.DTL;
using ChatBot.Data.DTL.Enums;
using System.Linq;

namespace ChatBot.Data
{
    public static class EntityExtensions
    {
        public static int[] GetSizeEuRange(this SizeUsType sizeUsType)
        {
            return GetSizeEuRange((SizeUsTypeEnum) sizeUsType.Id);
        }

        public static int[] GetSizeEuRange(this SizeUsTypeEnum sizeUsTypeEnum)
        {
            var value = (int) sizeUsTypeEnum;
            return new []{value, value + 1};
        }

        public static string? GetSizeUsValue(this SizeEuType sizeEuType)
        {
            var value = sizeEuType.Value;
            var enumType = typeof(SizeUsTypeEnum);
            var values = enumType.GetEnumValues();

            return value switch
            {
                < (int) SizeUsTypeEnum.Xs => SizeUsTypeEnum.Xs.ToString(),
                > (int) SizeUsTypeEnum.XXXl => SizeUsTypeEnum.XXXl.ToString(),
                _ => (from object? enumValue in values
                    where value == (int) enumValue || value - (int) enumValue == 1
                    select enumType.GetEnumName(enumValue)).FirstOrDefault()
            };
        }

        public static TEnum? GetValueFromName<TEnum>(this string entityName) where TEnum : Enum
        {
            var values = typeof(TEnum).GetEnumValues().ToEnumerable().ToList();

            if (!typeof(TEnum).GetEnumNames().Contains(entityName, StringComparer.CurrentCultureIgnoreCase)) return default;

            return (TEnum?) values.FirstOrDefault(x =>
                string.Equals(x.ToString(), entityName, StringComparison.CurrentCultureIgnoreCase));
        }

        public static IEnumerable<object> ToEnumerable(this Array source)
        {
            return source.Cast<object>().ToList();
        }
    }
}
