using Library.Core.Models;
using Library.Core.Services;
using Library.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BookService _bookService;
        public HomeController(ILogger<HomeController> logger, BookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpGet(Name = "AllBooks")]
        public IActionResult AllBooks()
        {
            _logger.LogTrace("Get All Books");

            var bookViewModel = new BookViewModel
            {
                Books = _bookService.GetAll()
            };

            _logger.LogTrace("Books count: {0}", bookViewModel.Books.Count);

            return View(bookViewModel);
        }

        #region Admin Methods

        [HttpGet]//нова сторінка
        [Authorize(CookieAuthenticationDefaults.AuthenticationScheme, Roles = "admin")]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        [Authorize(CookieAuthenticationDefaults.AuthenticationScheme, Roles = "admin")]
        public IActionResult AddBook(Book book)
        {
            _logger.LogTrace("AddBook");

            _bookService.AddBook(book);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize(CookieAuthenticationDefaults.AuthenticationScheme, Roles = "admin")]
        public IActionResult DeleteBook(string id)
        {
            _logger.LogTrace("DeleteBook");

            var book = _bookService.GetById(Guid.Parse(id));
            _bookService.DeleteBook(book);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize(CookieAuthenticationDefaults.AuthenticationScheme, Roles = "admin")]
        public IActionResult EditBook(string id)
        {
            var book = _bookService.GetById(Guid.Parse(id));
            return View(new EditBookModel {Book = book});
        }

        [HttpPost]
        [Authorize(CookieAuthenticationDefaults.AuthenticationScheme, Roles = "admin")]
        public IActionResult EditBook(EditBookModel bookModel)
        {
            _bookService.UpdateBook(bookModel.Book);
            return RedirectToAction("Index");
        }

        #endregion

        [HttpGet]
        public IActionResult BookDetails(string id)
        {
            var book = _bookService.GetById(Guid.Parse(id));
            return View(book);
        }
    }
}
