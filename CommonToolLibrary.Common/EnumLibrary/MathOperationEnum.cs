using System;

namespace CommonToolLibrary.Common.EnumLibrary
{
    using System.ComponentModel;

    public enum MathOperationEnum
    {
        /// <summary>
        /// 减
        /// </summary>
        [Description("减")]
        Minus = 0,
        /// <summary>
        /// 加
        /// </summary>
        [Description("加")]
        Plus = 1,
        /// <summary>
        /// 乘
        /// </summary>
        Multiply = 2,
        /// <summary>
        /// 除
        /// </summary>
        [Description("除")]
        Divide = 3
    }
}
