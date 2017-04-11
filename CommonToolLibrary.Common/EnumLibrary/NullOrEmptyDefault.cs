using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.Common.EnumLibrary
{
    using System.ComponentModel;

    public enum NullOrEmptyDefault
    {
        /// <summary>
        /// Empty
        /// </summary>
        [Description("Empty")]
        Empty=0,
        /// <summary>
        /// Null
        /// </summary>
        [Description("Null")]
        Null =1,
        /// <summary>
        /// Self
        /// </summary>
        [Description("Self")]
        Self =2
    }
}
