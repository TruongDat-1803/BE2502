using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnList
{
    // Extension methods must be defined in a static class
    public static class Demo2
    {
        public static List<int> GetObbNumber1(this List<int> numbers)
        {
            var result = new List<int>();
            foreach (var item in numbers)
            {
                if (item % 2 != 0)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static List<int> ShyWhere(this List<int> numbers, Func<int, bool> check)
        {
            var result = new List<int>();
            foreach (var item in numbers)
            {
                if (check(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
