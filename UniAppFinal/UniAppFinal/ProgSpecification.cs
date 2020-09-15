using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniAppFinal
{
    class ProgSpecification
    {
        public string Title { get; set; }
        public string Value { get; set; }
        public ProgSpecification(string Title, string Value)
        {
            this.Title = Title;
            this.Value = Value;
        }
    }
}
