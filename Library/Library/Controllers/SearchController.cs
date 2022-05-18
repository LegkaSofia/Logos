using System.Linq;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class SearchController : Controller
    {
        private BookService _bookService;

        public SearchController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost]
        public IActionResult Search(string query)
        {
            var searchModel = new BookSearchModel
            {
                Query = query,
                Books = _bookService.GetAll().Where(x => x.Name.Contains(query)).ToList()
            };
            return View(searchModel);
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }
    }
}