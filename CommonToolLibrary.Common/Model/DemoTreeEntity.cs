using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.Common.Model
{
    public class DemoTreeEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<DemoTreeEntity> Child { get; set; }
    }
}
