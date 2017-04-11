using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.Common.Model
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 6)]
    public struct MyStructEntity
    {
        [FieldOffset(0)]
        public int Value;
        [FieldOffset(0)]
        public short Low;
        [FieldOffset(2)]
        public short Hi;
        [FieldOffset(4)]
        public short X;
    }
}
