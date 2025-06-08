using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnException
{
    internal class Demo
    {
        public void InputStudent()
        {
            try
            {
                Console.WriteLine("Input student name: ");
                var name = Console.ReadLine();

                Console.WriteLine("Input student age: ");
                var age = int.Parse(Console.ReadLine());

                Console.WriteLine("Input student lit: ");
                var lit = double.Parse(Console.ReadLine());

                Console.WriteLine("Input student math: ");
                var math = double.Parse(Console.ReadLine());

                var avg = (lit + math) / 2;

                Console.WriteLine($"Student name: {name}, Student age: {age}, Student average score: {avg}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Please input again");
                InputStudent();
            }        
        }
        public void InputStudent1()
        {
            Console.WriteLine("Input student name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Input student age: ");
            var checkAge = int.TryParse(Console.ReadLine(), out int age);
            if(!checkAge)
            {
                Console.WriteLine("Please input age again");
                return;
            }

            Console.WriteLine("Input student lit: ");
            var checkLit = double.TryParse(Console.ReadLine(), out double lit);
            if (!checkLit)
            {
                Console.WriteLine("Please input lit again");
                return;
            }

            Console.WriteLine("Input student math: ");
            var checkMath = double.TryParse(Console.ReadLine(), out double math);
            if (!checkMath)
            {
                Console.WriteLine("Please input math again");
                return;
            }
            var avg = (lit + math) / 2;
            Console.WriteLine($"Student name: {name}, Student age: {age}, Student average score: {avg}");
        }
    }
}
