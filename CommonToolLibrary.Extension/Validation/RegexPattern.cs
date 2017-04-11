using System.Text.RegularExpressions;

namespace CommonToolLibrary.Extension.Validation
{
    public class RegexPattern
    {
        /// <summary>
        /// 所有整数
        /// </summary>
        public static readonly Regex Integer =new Regex("^(0|[+|-]?[0-9]*[1-9][0-9]*)$");
        /// <summary>
        /// 正整数
        /// </summary>
        public static readonly Regex PositiveInteger =new Regex("^([+]?[0-9]*[1-9][0-9]*)$");
        /// <summary>
        /// 负整数
        /// </summary>
        public static readonly Regex NegativeInteger =new Regex("^(-[0-9]*[1-9][0-9]*)$");
        /// <summary>
        /// 所有小数
        /// </summary>
        public static readonly Regex Decimal =new Regex("^([+|-]?[0-9]*[1-9][0-9]*[.][0-9]+|[+|-]?[0][.][0-9]*[1-9]+[0-9]+|[0]+[.][0]+)$");
        /// <summary>
        /// 正小数
        /// </summary>
        public static readonly Regex PositiveDecimal =new Regex("^([+]?[0-9]*[1-9][0-9]*[.][0-9]+|[+]?[0][.][0-9]*[1-9]+[0-9]+)$");
        /// <summary>
        /// 负小数
        /// </summary>
        public static readonly Regex NegativeDecimal =new Regex("^([-][0-9]*[1-9][0-9]*[.][0-9]+|[-][0][.][0-9]*[1-9]+[0-9]+)$");
        /// <summary>
        /// 所有整数或小数
        /// </summary>
        public static readonly Regex IntegerOrDecimal = new Regex("^(0|[+|-]?[0][.][0-9]*[1-9]+[0-9]*|[0]+[.][0]+|[+|-]?[0-9]*[1-9][0-9]*|[+|-]?[0-9]*[1-9][0-9]*[.][0-9]+)$");
    }
}