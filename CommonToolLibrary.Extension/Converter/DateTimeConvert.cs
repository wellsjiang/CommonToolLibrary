using System;

namespace CommonToolLibrary.Extension.Converter
{
    public static class DateTimeConvert
    {
        /// <summary>
        ///  Unix默认开始时间
        /// </summary>
        private static readonly DateTime UnixDefaultTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTime.Now.Kind);
        
        /// <summary>
        /// 转Unix时间戳
        /// </summary>
        /// <param name="dateTime">源</param>
        /// <returns>Unix时间戳</returns>
        public static long ToUnixTimestamp(this DateTime dateTime)
        {
            return Convert.ToInt64((dateTime - UnixDefaultTime).TotalSeconds);
        }

        
    }
}