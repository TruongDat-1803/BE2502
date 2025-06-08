using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEF.Model
{
    public class SearchQuery
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int SkipNo => (PageIndex -1) * PageSize;
        public string Keyword { get; set; } = string.Empty;
    }
}
