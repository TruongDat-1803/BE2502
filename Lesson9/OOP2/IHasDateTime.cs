using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal interface IHasDateTime
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
