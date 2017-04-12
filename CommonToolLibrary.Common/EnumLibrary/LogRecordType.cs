using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.Common.EnumLibrary
{
    using System.ComponentModel;

    public enum LogRecordType
    {
        /// <summary>
        /// 正常日志
        /// </summary>
        [Description("正常日志")]
        Normal=0,
        /// <summary>
        /// 异常日志
        /// </summary>
        [Description("异常日志")]
        Exception =1
    }
}
