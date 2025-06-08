using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnArray
{
    internal class Demo
    {
        string[] engs = { "table", "chair", "pen", "book", "apple", "available" };
        string[] vns = { "bàn", "ghế", "bút", "sách", "quả táo", "có sẵn" };
        public string LookUp(String eng)
        {  
            for (int i = 0; i < engs.Length; i++)
            {
                if (engs[i].Equals(eng, StringComparison.OrdinalIgnoreCase))
                {
                    return vns[i];
                }
            }
            return "Không tìm thấy";
        }
    }
}