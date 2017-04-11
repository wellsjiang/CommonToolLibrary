using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.Common.Model
{
    using CommonToolLibrary.Common.EnumLibrary;

    public class DemoChildEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public object ObjectValue { get; set; }

        public NullOrEmptyDefault EnumValue { get; set; }
    }
}
