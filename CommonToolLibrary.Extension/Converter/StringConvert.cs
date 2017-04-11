using System.Linq;
using CommonToolLibrary.Extension.Validation;

namespace CommonToolLibrary.Extension.Converter
{
    using System;
    using System.Text;
    using CommonToolLibrary.Common.EnumLibrary;

    /// <summary>
    /// 字符串转换类
    /// </summary>
    public static class StringConvert
    {
        /// <summary>
        /// string转换sbyte
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(默认0)</param>
        /// <param name="convertDecimal">是否支持小数转换整数(默认true且直接取整)</param>
        /// <returns>转换结果</returns>
        public static sbyte ToSByte(this string input, sbyte defaultValue = 0, bool convertDecimal = true)
        {
            var convertValue = defaultValue;
            var source = input;
            if (!StringNumberCheck(source, convertDecimal)) return convertValue;
            if (convertDecimal) source = source.Split('.').First();
            if (sbyte.TryParse(source, out convertValue)) return convertValue;
            return defaultValue;
        }

        /// <summary>
        /// string转换short
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(默认0)</param>
        /// <param name="convertDecimal">是否支持小数转换整数(默认true且直接取整)</param>
        /// <returns>转换结果</returns>
        public static byte ToByte(this string input, byte defaultValue = 0, bool convertDecimal = true)
        {
            var convertValue = defaultValue;
            var source = input;
            if (!StringNumberCheck(source, convertDecimal) || source.Contains("-")) return convertValue;
            if (convertDecimal) source = source.Split('.').First();
            if (byte.TryParse(source, out convertValue)) return convertValue;
            return defaultValue;
        }

        /// <summary>
        /// string转换short
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(默认0)</param>
        /// <param name="convertDecimal">是否支持小数转换整数(默认true且直接取整)</param>
        /// <returns>转换结果</returns>
        public static short ToShort(this string input, short defaultValue = 0, bool convertDecimal = true)
        {
            var convertValue = defaultValue;
            var source = input;
            if (!StringNumberCheck(source, convertDecimal)) return convertValue;
            if (convertDecimal) source = source.Split('.').First();
            if (short.TryParse(source, out convertValue)) return convertValue;
            return defaultValue;
        }

        /// <summary>
        /// string转换ushort
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(默认0)</param>
        /// <param name="convertDecimal">是否支持小数转换整数(默认true且直接取整)</param>
        /// <returns>转换结果</returns>
        public static ushort ToUShort(this string input, ushort defaultValue = 0, bool convertDecimal = true)
        {
            var convertValue = defaultValue;
            var source = input;
            if (!StringNumberCheck(source, convertDecimal) || source.Contains("-")) return convertValue;
            if (convertDecimal) source = source.Split('.').First();
            if (ushort.TryParse(source, out convertValue)) return convertValue;
            return defaultValue;
        }

        /// <summary>
        /// string转换int
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(默认0)</param>
        /// <param name="convertDecimal">是否支持小数转换整数(默认true且直接取整)</param>
        /// <returns>转换结果</returns>
        public static int ToInt(this string input, int defaultValue = 0, bool convertDecimal = true)
        {
            var convertValue = defaultValue;
            var source = input;
            if (!StringNumberCheck(source, convertDecimal)) return convertValue;
            if (convertDecimal) source = source.Split('.').First();
            if (int.TryParse(source, out convertValue)) return convertValue;
            return defaultValue;
        }

        /// <summary>
        /// string转换uint
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(默认0)</param>
        /// <param name="convertDecimal">是否支持小数转换整数(默认true且直接取整)</param>
        /// <returns>转换结果</returns>
        public static uint ToUInt(this string input, uint defaultValue = 0, bool convertDecimal = true)
        {
            var convertValue = defaultValue;
            var source = input;
            if (!StringNumberCheck(source, convertDecimal) || source.Contains("-")) return convertValue;
            if (convertDecimal) source = source.Split('.').First();
            if (uint.TryParse(source, out convertValue)) return convertValue;
            return defaultValue;
        }

        /// <summary>
        /// string转换long
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(默认0)</param>
        /// <param name="convertDecimal">是否支持小数转换整数(默认true且直接取整)</param>
        /// <returns>转换结果</returns>
        public static long ToLong(this string input, long defaultValue = 0, bool convertDecimal = true)
        {
            var convertValue = defaultValue;
            var source = input;
            if (!StringNumberCheck(source, convertDecimal)) return convertValue;
            if (convertDecimal) source = source.Split('.').First();
            if (long.TryParse(source, out convertValue)) return convertValue;
            return defaultValue;
        }

        /// <summary>
        /// string转换ulong
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(默认0)</param>
        /// <param name="convertDecimal">是否支持小数转换整数(默认true且直接取整)</param>
        /// <returns>转换结果</returns>
        public static ulong ToULong(this string input, ulong defaultValue = 0, bool convertDecimal = true)
        {
            var convertValue = defaultValue;
            var source = input;
            if (!StringNumberCheck(source, convertDecimal) || source.Contains("-")) return convertValue;
            if (convertDecimal) source = source.Split('.').First();
            if (ulong.TryParse(source, out convertValue)) return convertValue;
            return defaultValue;
        }

        /// <summary>
        /// string转float
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(默认0)</param>
        /// <returns>转换结果</returns>
        public static float ToFloat(this string input, float defaultValue = 0)
        {
            var convertValue = defaultValue;
            if (string.IsNullOrWhiteSpace(input) || !RegexPattern.IntegerOrDecimal.IsMatch(input)) return convertValue;
            if (float.TryParse(input, out convertValue)) return convertValue;
            return defaultValue;
        }

        /// <summary>
        /// string转double
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(默认0)</param>
        /// <returns>转换结果</returns>
        public static double ToDouble(this string input, double defaultValue = 0)
        {
            var convertValue = defaultValue;
            if (string.IsNullOrWhiteSpace(input) || !RegexPattern.IntegerOrDecimal.IsMatch(input)) return convertValue;
            if (double.TryParse(input, out convertValue)) return convertValue;
            return defaultValue;
        }

        /// <summary>
        /// string转float
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(默认0)</param>
        /// <returns>转换结果</returns>
        public static decimal ToDecimal(this string input, decimal defaultValue = 0)
        {
            var convertValue = defaultValue;
            if (string.IsNullOrWhiteSpace(input) || !RegexPattern.IntegerOrDecimal.IsMatch(input)) return convertValue;
            if (decimal.TryParse(input, out convertValue)) return convertValue;
            return defaultValue;
        }

        /// <summary>
        /// string转换bool 支持 是 否、真 假、0 1、true false(忽略大小写)
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="defaultValue">缺省值(默认false)</param>
        /// <returns></returns>
        public static bool ToBool(this string input, bool defaultValue = false)
        {
            var convertValue = defaultValue;
            if (string.IsNullOrWhiteSpace(input)) return convertValue;
            var temp = input.Trim().ToLower();
            if (temp == "false" || temp == "0" || temp == "否" || temp == "假")
            {
                return false;
            }
            else if (temp == "true" || temp == "1" || temp == "是" || temp == "真")
            {
                return true;
            }
            return convertValue;
        }

        /// <summary>
        /// string转DateTime
        /// </summary>
        /// <param name="input"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string input, DateTime defaultValue)
        {
            return DateTime.TryParse(input, out DateTime outResult) ? outResult : defaultValue;
        }

        /// <summary>BASE64编码(UTF-8编码)</summary>
        /// <param name="input">源</param>
        /// <returns>编码后的字符串</returns>
        public static string ToBase64(this string input)
        {
            return string.IsNullOrEmpty(input) ? string.Empty : Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        }

        /// <summary>BASE64解码(UTF-8编码)</summary>
        /// <param name="input">源</param>
        /// <param name="base64ConvertFaildReturn">转换失败返回信息(默认返回自身数据)</param>
        /// <returns>字符串</returns>
        public static string FromBase64(this string input, Base64ConvertFaildDefalut base64ConvertFaildReturn = Base64ConvertFaildDefalut.Self)
        {
            try
            {
                return string.IsNullOrEmpty(input) ? string.Empty : Encoding.UTF8.GetString(Convert.FromBase64String(input));
            }
            catch (Exception)
            {
                switch (base64ConvertFaildReturn)
                {
                    case Base64ConvertFaildDefalut.Self:
                        return input;
                    case Base64ConvertFaildDefalut.Empty:
                        return string.Empty;
                    case Base64ConvertFaildDefalut.Null:
                        return null;
                    default: return input;
                }
            }
        }

        /// <summary>
        /// 字符串验证
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="convertDecimal">是否支持小数转换整数(默认true)</param>
        /// <returns>结果</returns>
        private static bool StringNumberCheck(string input, bool convertDecimal = true)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            if (!convertDecimal)
            {
                if (!RegexPattern.Integer.IsMatch(input)) return false;
            }
            else
            {
                if (!RegexPattern.IntegerOrDecimal.IsMatch(input)) return false;
            }
            return true;
        }

    }
}
