using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEF.Entities
{
    [Table("Books")]
    public class Book : BaseEntity<Guid>
    {
        [Column(TypeName = "nvarchar(500)")]
        public string Name { get; set; } = string.Empty;
        public Guid AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
