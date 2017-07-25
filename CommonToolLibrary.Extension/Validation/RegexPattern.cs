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
        /// <summary>
        /// IP格式校验
        /// </summary>
        public static readonly Regex IP=new Regex(@"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$");
        /// <summary>
        /// 局域网IP格式校验
        /// </summary>
        public static readonly Regex LanIp=new Regex(@"^((192\.168|172\.([1][6-9]|[2]\d|3[01]))(\.([2][0-4]\d|[2][5][0-5]|[01]?\d?\d)){2}|10(\.([2][0-4]\d|[2][5][0-5]|[01]?\d?\d)){3})$");
    }
}