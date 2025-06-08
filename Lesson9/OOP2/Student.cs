using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public abstract class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public double Math { get; set;  }
        public double Literature { get; set; }

        public Student(string name, int age, double math, double literature, string address)
        {
            Name = name;
            Age = age;
            Math = math;
            Literature = literature;
            Address=address;
        }
        public Student()
        {
        }
        public virtual string GetInfo()
        {
            return $"Tên: {Name}, Tuổi: {Age}, Địa chỉ: {Address} Toán: {Math}, Văn: {Literature}";
        }
        public abstract double GetAverage();
    }
}
