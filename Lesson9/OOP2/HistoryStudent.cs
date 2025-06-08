using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class HistoryStudent : Student , IHasDateTime
    {
        
        public HistoryStudent(string name, int age, double math, double literature, string address, double history) : base(name, age, math, literature, address)
        {
            History = history;
        }

        public HistoryStudent()
        {

        }
        public double History { get; set; }
        public override double GetAverage()
        {
            return (Math + Literature + History * 3) / 5;
        }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
