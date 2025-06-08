using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnList
{
    internal class LearnLinq
    {
        private List<int> _list = new List<int>() { 18, 03, 28, 08, 31, 07, 2003, 2024 };
        public void DemoWhere()
        {
            var result = _list.Where(x => x % 2 != 0).Where(x=> x <= 50).ToList();

            Print(result);
        }
        public void DemoFistLast()
        {
            var result = _list.FirstOrDefault(x => x % 3 != 0);
            Print(result);
        }

        private void Print (object obj)
        {
            if (obj == null)
            {
                Console.WriteLine("no data");
            }
            else
            {
                if (obj is List<int> list)
                {
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (obj is double doubleValue)
                {
                    Console.WriteLine((double)obj);
                }
                else if (obj is List<string> listString)
                {
                    foreach (var item in listString)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine((int)obj);
                }
            }
        }
        public void DemoOrder()
        {
            //Tăng dần
            var result = _list.OrderBy(x => x).ToList();
            //Giảm dần
            var result2 = _list.OrderByDescending(x => x).ToList();
            Print(result2);
        }
        public void DemoSum()
        {
            var result = _list.Sum();
            //Giá trị trung bình
            var result2 = _list.Average();
            Console.WriteLine(result2);
        }
        public void DemoSelect()
        {
            var result = _list.Select(x => x * 2).ToList();

            var result2 = _list.Select(x => $"number: {x + 2}").ToList();
            Print(result2);
        }
        public void DemoTakeSkip()
        {
            //Bỏ qua 2 phần tử đầu tiên và lấy 3 phần tử tiếp theo
            var result = _list.Skip(2).Take(3).ToList();
            Print(result);
        }
        public void DemoAnyAll()
        {
            //Kiểm tra xem có phần tử nào chia hết cho 3 hay không
            var result = _list.Any(x => x % 3 == 0);

            //Kiểm tra xem có rỗng hay không
            var result2 = _list.Any();
            var check = _list.Count != 0;

            return;
        }
        public void DemoContain()
        {
            //Kiểm tra xem có phần tử nào trong danh sách có giá trị 3 hay không
            var result = _list.Contains(3);
            Print(result);
        }
    }
}
