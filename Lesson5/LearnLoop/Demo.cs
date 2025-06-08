using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLoop
{
    internal class Demo
    {
        public void PrintNumber()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void InputStudent()
        {
            bool continueInput = true;
            var input = "y";
            while (continueInput)
            {               
                if (input == "y")
                {
                    InputStudent1();
                }
                else
                {
                    continueInput = false;
                }
                Console.WriteLine("Do you want to input student? (y/n)");
                input = Console.ReadLine();
            }
        }
        public void InputStudent1()
        {
            Console.WriteLine("Input student name: ");
            var name = Console.ReadLine();

            var age = ValidateInt("age");


            Func<double, bool> litCondition = number => number >= 0 && number <= 10;
            var math = ValidateDouble("math", litCondition);

            var lit = ValidateDouble("lit", s => s >= 0 && s <= 10);

            var avg = (lit + math) / 2;
            Console.WriteLine($"Student name: {name}, Student age: {age}, Student average score: {avg}");
        }

        public double ValidateDouble(string field, Func<double, bool> condition = null)
        {
            Console.WriteLine($"Input {field}: ");
            var check = double.TryParse(Console.ReadLine(), out double value);
            if(condition != null)
            {
                check = condition(value);
            }
            while (!check)
            {
                Console.WriteLine($"Please input {field} again");
                check = double.TryParse(Console.ReadLine(), out value);
                if (condition != null)
                {
                    check = condition(value);
                }
            }
            return value;
        }

        public int ValidateInt(string field)
        {
            Console.WriteLine($"Input {field}: ");
            var check = int.TryParse(Console.ReadLine(), out int value);
            while (!check)
            {
                Console.WriteLine($"Please input {field} again");
                check = int.TryParse(Console.ReadLine(), out value);
            }
            return value;
        }
    }
}
