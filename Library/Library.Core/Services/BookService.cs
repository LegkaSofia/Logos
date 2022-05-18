using System;
using Library.Core.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.IO;

namespace Library.Core.Services
{
    public class BookService
    {
        private readonly ILogger<BookService> _logger;
        private List<Book> books;

        public BookService(ILogger<BookService> logger)
        {
            _logger = logger;
            books = new List<Book>
            {
                new Book { Author = "Gogol", Genre = "Drama", Name = "Dead souls" },
                new Book { Author = "Conan Doyle", Genre = "Detective", Name = "The Adventures of Sherlock Holmes" },
                new Book { Author = "Joanne Rowling", Genre = "Fantasy", Name = "Harry Potter" },
                new Book { Author = "Лепкий Богдан", Genre = "Повість", Name = "Мотря" },
                new Book { Author = "Грабовський Павло", Genre = "Вірші", Name = "Щоглик" },
                new Book { Author = "Тарас Шевченко", Genre = "Поема", Name = "Гайдамаки" },
                new Book { Author = "Гуменюк Надія", Genre = "Роман", Name = "Дожити до весни" },
                new Book { Author = "Панас Мириний", Genre = "Історія", Name = "Морозенко" },
                new Book { Author = "Гончар Олесь", Genre = "Новела", Name = "За мить щастя" },
                new Book { Author = "Грінченко Борис", Genre = "Оповідання", Name = "Сам собі пан" }
            };
            foreach (var book in books)
            {
                try
                {
                    var text = File.ReadAllText($"Books/{book.Author}.txt");
                    book.Content = text;
                }
                catch (Exception e)
                {
                    _logger.LogWarning(e, $"Fail to read content for book: {book.Name}");
                }
            }
        }

        public List<Book> GetAll()
        {
            return books;
        }

        public Book GetById(Guid id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }
        
        public Book GetById(Book book)
        {
            return books.FirstOrDefault(x => x.Id == book.Id);
        }
        
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        
        public void DeleteBook(Book book)
        {
            var b = GetById(book);
            books.Remove(b);
        }

        public void UpdateBook(Book book)
        {
            var b = GetById(book);
            if (b == null)
            {
                _logger.LogWarning($"Fail to update book. No book with id {book.Id}");
                return;
            }

            _logger.LogTrace($"Book ({book.Id}) updated");
            b.Author = book.Author;
            b.Content = book.Content;
            b.Genre = book.Genre;
            b.Name = book.Name;
        }
    }
}
