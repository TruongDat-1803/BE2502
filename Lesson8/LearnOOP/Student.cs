using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP
{
    internal class Student
    {
        private int Age;
        private string Address;
        public string Name { get; set; }
        public int _Age
        {
            get
            {
                return Age;
            }
            set
            {
                if (value >= 11 && value <= 15)
                {
                    Age = value;
                }
                else
                {
                    throw new Exception("Age is not correct");
                }
            }
        }
        public string _Address
        {
            get { return $"{Address} Hà Nội"; }
            set { Address = value; }
        }


        public Student()
        {
            
        }
        public Student(string name, int age, string address)
        {
            Name = name;
            _Age = age;
            _Address = address;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Họ và tên: {Name}");
            Console.WriteLine($"Tuổi: {Age}");
            Console.WriteLine($"Địa chỉ: {Address}");
        }
    }
}
