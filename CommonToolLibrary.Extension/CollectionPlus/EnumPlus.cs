using System;
using System.Collections.Generic;

namespace CommonToolLibrary.Extension.CollectionPlus
{
    using System.Linq;
    using CommonToolLibrary.Extension.Converter;

    /// <summary>
    /// 枚举拓展类
    /// </summary>
    public static class EnumPlus
    {
        /// <summary>
        /// 根据枚举值获取枚举键
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="enumValue">枚举值</param>
        /// <param name="defaultValue">缺省值(string.Empty)</param>
        /// <returns></returns>
        public static string GetKey(Type enumType, long enumValue, string defaultValue = "")
        {
            var temp = Enum.GetValues(enumType).Cast<Enum>().Where(e => Convert.ToInt64(e) == enumValue);
            return temp.Any() ? temp.First().GetKey() : defaultValue;
        }
        
        /// <summary>
        /// 根据枚举值获取枚举描述
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="enumValue">枚举值</param>
        /// <param name="defaultValue">缺省值(string.Empty)</param>
        /// <returns></returns>
        public static string GetDescription(Type enumType, long enumValue, string defaultValue = "")
        {
            var temp = Enum.GetValues(enumType).Cast<Enum>().Where(e => Convert.ToInt64(e) == enumValue);
            return temp.Any() ? temp.First().GetDescription(defaultValue) : defaultValue;
        }
        
        /// <summary>
        /// 枚举键值字典
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <returns>字典</returns>
        public static Dictionary<string, int> GetKeyValue(Type enumType)
        {
            var array = Enum.GetValues(enumType);
            return array.Cast<Enum>().ToDictionary(item => item.GetKey(), item => item.GetValue());
        }

        /// <summary>
        /// 得到枚举值键字典
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <returns>字典</returns>
        public static Dictionary<int, string> GetValueKey(Type enumType)
        {
            var array = Enum.GetValues(enumType);
            return array.Cast<Enum>().ToDictionary(item => item.GetValue(), item => item.GetKey());
        }

        /// <summary>
        /// 得到枚举键描述字典
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="defaultValue">枚举描述缺省值(string.Empty)</param>
        /// <returns>字典</returns>
        public static Dictionary<string, string> GetKeyDescription(Type enumType, string defaultValue = "")
        {
            var array = Enum.GetValues(enumType);
            return array.Cast<Enum>().ToDictionary(item => item.GetKey(), item => item.GetDescription(defaultValue));
        }

        /// <summary>
        /// 得到枚举值描述字典
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="defaultValue">枚举描述缺省值(string.Empty)</param>
        /// <returns>字典</returns>
        public static Dictionary<int, string> GetValueDescription(Type enumType, string defaultValue = "")
        {
            var array = Enum.GetValues(enumType);
            return array.Cast<Enum>().ToDictionary(item => item.GetValue(), item => item.GetDescription(defaultValue));
        }

        /// <summary>
        /// 枚举是否包含该枚举键
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="key">值</param>
        /// <param name="caseSensitive">大小写敏感(默认true)</param>
        /// <returns>结果</returns>
        public static bool ContainKey(Type enumType, string key,bool caseSensitive=true)
        {
            if (string.IsNullOrWhiteSpace(key)) return false;
            var temp = Enum.GetValues(enumType).Cast<Enum>().Where(e => e.ToString().ToLower() == key.ToLower());
            if (temp.Any())
            {
                return !caseSensitive || temp.Any(x => x.ToString() == key);
            }
            return false;
        }

        /// <summary>
        /// 是否包含枚举值
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="value">枚举值</param>
        /// <returns>结果</returns>
        public static bool ContainValue(Type enumType, long value)
        {
            return Enum.GetValues(enumType).Cast<Enum>().Any(e => e.GetValue() == value);
        }

        /// <summary>
        /// 是否包含枚举描述(空字符串默认为false)
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="description">描述</param>
        /// <returns>结果</returns>
        public static bool ContainDescription(Type enumType, string description)
        {
            if(string.IsNullOrWhiteSpace(description)) return false;
            return Enum.GetValues(enumType).Cast<Enum>().Any(e => e.GetDescription() == description);
        }
    }
}
