using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGeneric.Entities
{
    public class Blog :BaseEntity <string>
    {
        public string Title { get; set; }
        public string Detail { get; set; }
    }
}
