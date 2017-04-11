using System;

namespace CommonToolLibrary.Extension.Converter
{
    using System.ComponentModel;
    using System.Reflection;

    /// <summary>
    /// 枚举转换类
    /// </summary>
    public static class EnumConvert
    {
        /// <summary>
        /// 枚举值
        /// </summary>
        /// <param name="input">源</param>
        /// <returns>枚举值</returns>
        public static int GetValue(this Enum input)
        {
            return input.GetHashCode();
        }

        /// <summary>
        /// 枚举键
        /// </summary>
        /// <param name="input">源</param>
        /// <returns>枚举键</returns>
        public static string GetKey(this Enum input)
        {
            return input.ToString();
        }

        /// <summary>
        /// 枚举描述(Description特性描述)
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(string.Empty)</param>
        /// <returns>描述</returns>
        public static string GetDescription(this Enum input, string defaultValue = "")
        {
            var enumInfo = input.GetType().GetRuntimeField(input.ToString());
            var enumAttributes = (DescriptionAttribute[])enumInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return enumAttributes.Length > 0 ? enumAttributes[0].Description : defaultValue;
        }

        /// <summary>
        /// 获取枚举描述(Description特性描述), 当描述为空时获取枚举键名
        /// </summary>
        /// <param name="input">源</param>
        /// <returns>描述或键名</returns>
        public static string GetDescriptionOrKey(this Enum input)
        {
            var description = input.GetDescription();
            if (string.IsNullOrWhiteSpace(description)) return input.GetKey();
            return description;
        }
    }
}
