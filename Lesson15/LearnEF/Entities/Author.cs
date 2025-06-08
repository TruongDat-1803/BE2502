using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEF.Entities
{
    [Table("Authors")]
    public class Author : BaseEntity<Guid>
    {
        [Column(TypeName = "nvarchar(500)")]
        public string Name { get; set; } = string.Empty;
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
