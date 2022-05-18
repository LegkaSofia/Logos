using System.Collections.Generic;
using Library.Core.Models;

namespace Library.Controllers
{
    public class BookSearchModel
    {
        public List<Book> Books { get; set; }
        public string Query { get; set; }
    }
}