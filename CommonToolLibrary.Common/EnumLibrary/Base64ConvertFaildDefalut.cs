using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.Common.EnumLibrary
{
    using System.ComponentModel;

    public enum Base64ConvertFaildDefalut
    {
        /// <summary>
        /// Self
        /// </summary>
        [Description("Self")]
        Self=0,
        /// <summary>
        /// Empty
        /// </summary>
        [Description("Empty")]
        Empty =1,
        /// <summary>
        /// Null
        /// </summary>
        [Description("Null")]
        Null =2
    }
}
