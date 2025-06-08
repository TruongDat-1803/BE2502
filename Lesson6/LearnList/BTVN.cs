using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnList
{
    internal class BTVN
    {
        private List<int> _list = new List<int>()
        {
            18, 03, 28, 08, 31, 07, 2003, 2024
        };
        public void Sum_SoLe()
        {
            var result = _list.Where(x => x % 2 != 0).Sum();
            Console.WriteLine("Tổng các số lẻ là: " + result);
        }
        public void Select_List()
        {
            //Lấy các số lớn hơn 3 và chia hết cho 3
            var result = _list
                .Where(x => x > 3 && x % 3 == 0)
                .OrderBy(x => x)
                .ToList();
            Console.WriteLine("Các số lớn hơn 3 và chia hết cho 3 là: ");
            foreach (var item in result)
            {
                Console.Write(" " + item);
            }
        }
    }
}
