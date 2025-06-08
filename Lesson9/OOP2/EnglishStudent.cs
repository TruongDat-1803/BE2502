using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class EnglishStudent : Student, ICheckExamCondition, IHasDateTime
    {
        public EnglishStudent(string name, int age, double math, double literature, string address, double english) : base(name, age, math, literature, address)
        {
            English = english;
        }

        public EnglishStudent()
        {
        }
        public double English { get; set; }
        public override string GetInfo()
        {
            return base.GetInfo() +$", Tiếng Anh: {English}";
        }
        public override double GetAverage()
        {
            return (Math + Literature + English * 2) / 4;
        }
        public bool IsPassExam()
        {
            return English >= 7;
        }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
