using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCondition
{
    internal class Demo
    {
        public string GetStudentResult(double score)
        {
            var result = "";
            if (score == 5)
            {
                result = "TB";
            }
            else if (score > 5)
            {
                result = "Khá";
            }
            else
            {
                result = "Yếu";
            }

            return result;
        }

        public int GetMaxNumber(int a, int b, int c)
        {
            var max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }

        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsLeapYear2(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        public bool IsLeapYear3(int year)
            => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
