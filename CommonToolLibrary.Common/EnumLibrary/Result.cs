using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.Common.EnumLibrary
{
    public class Result
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        public string Message { get; set; }
    }
}
