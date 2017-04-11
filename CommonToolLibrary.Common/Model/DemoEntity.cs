using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.Common.Model
{
    using CommonToolLibrary.Common.EnumLibrary;

    public class DemoEntity
    {
        public int Id { get; set; }

        public int? IdNull { get; set; }

        public string Name { get; set; }

        public DemoChildEntity Child { get; set; }

        public List<DemoChildEntity> ChildList { get; set; }

        public IList<DemoChildEntity> ChildIlIst { get; set; }

        public IEnumerable<DemoChildEntity> ChildIEnumerable { get; set; }

        public DemoChildEntity[] ChildArray { get; set; }

        public NullOrEmptyDefault EnumValue { get; set; }
    }
}
