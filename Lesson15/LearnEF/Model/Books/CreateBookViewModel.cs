using BookApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Model.Books
{
    public class CreateBookViewModel
    {
        public string Name { get; set; } = string.Empty;
        public Guid AuthorId { get; set; }
    }
}
