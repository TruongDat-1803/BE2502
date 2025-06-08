using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnList
{
    internal class Demo
    {
        List<string> engs = new List<string>  { "table", "chair", "pen", "book", "apple", "available" };
        List<string> vns = new List<string> { "bàn", "ghế", "bút", "sách", "quả táo", "có sẵn" };
        public string LookUp(String eng)
        {
            for (int i = 0; i < engs.Count; i++)
            {
                if (engs[i].Equals(eng, StringComparison.OrdinalIgnoreCase))
                {
                    return vns[i];
                }
            }
            return "Không tìm thấy";
        }
        public List<string> LookUp1(string eng)
        {
            var result = new List<string>();
            for (int i = 0; i < engs.Count; i++)
            {
                if (engs[i].Contains(eng, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(vns[i]);
                }
            }
            return result;
        }

        public List<int> GetOddNumber(List<int> ints)
        {
            var result = new List<int>();
            foreach (var item in ints)
            {
                if (item % 2 != 0)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
