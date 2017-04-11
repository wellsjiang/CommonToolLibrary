using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.Extension.CollectionPlus
{
    using System.Linq;
    using System.Text.RegularExpressions;

    using CommonToolLibrary.Common.EnumLibrary;

    public static class StringPlus
    {
        /// <summary>
        /// string去除空格或null转空字符串
        /// </summary>
        /// <param name="input">源</param>
        /// <returns>结果</returns>
        public static string TrimEmptyOrNull(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;
            return input.Trim();
        }

        /// <summary>
        /// 去除XML字符串开头隐藏多余字符
        /// </summary>
        /// <param name="input">源</param>
        /// <returns>结果</returns>
        public static string TrimXmlEmptyString(this string input)
        {
            //说明：对象经过XML序列化后，会加入一些特定字符。在xml文件的开头有隐藏的非法字符，之所以说隐藏，是因为在debug时快速监视看到的数据完全是正常的(即开始就是类似<xml...)，但是取得第一个字符却不是<，而是个双引号,所以采用正则表达式去除第一个<之前所有字符
            if (string.IsNullOrWhiteSpace(input) || !input.TrimEnd().EndsWith(">")) return input;
            return Regex.Replace(input, "^[^<]", "");
        }

        /// <summary>
        /// 获取字节长度
        /// </summary>
        /// <param name="input">源</param>
        /// <returns>字节</returns>
        public static long CharLength(this string input)
        {
            var charCount = 0;
            if (input == null) return charCount;
            var charArray = input.ToCharArray();
            foreach (var item in charArray)
            {
                if (item >= 0x4e00 && item <= 0x9fbb)
                {
                    charCount += 2;
                }
                else
                {
                    charCount += 1;
                }
            }
            return charCount;
        }

        /// <summary>
        /// 截取特定长度字符串
        /// </summary>
        /// <param name="input">源</param>
        /// <param name="length">截取长度(当小于等于0时默认返回空字符串)</param>
        /// <param name="nullOrEmptyDefaut">当源为null或空字符串是返回值(默认为空字符串)</param>
        /// <returns>结果</returns>
        public static string SubstringPlus(this string input,int length, NullOrEmptyDefault nullOrEmptyDefaut = NullOrEmptyDefault.Empty)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                switch (nullOrEmptyDefaut)
                {
                    case NullOrEmptyDefault.Empty:
                        return string.Empty;
                    case NullOrEmptyDefault.Null:
                        return null;
                    case NullOrEmptyDefault.Self:
                        return input;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(nullOrEmptyDefaut), nullOrEmptyDefaut, null);
                }
            }
            if (length <= 0) return string.Empty;
            return input.Length < length ? input : input.Substring(0, length);
        }
    }
}
