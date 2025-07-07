using BookApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Models.Books
{
    public class UpdateBookViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AuthorName { get; set; }
        public Guid AuthorId { get; set; }
    }
}
