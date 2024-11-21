using libreria_EESA.Data;
using libreria_EESA.Data.Models;
using Libreria_EESA.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Libreria_EESA.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }
        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverURL = book.CoverURL,
                DateAdded = DateTime.Now,
                PublisherId = book.PublisherID
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }
        public List<Book> GetAllBks() => _context.Books.ToList(); //GET por cosas
        public Book GetBookById(int bookid) => _context.Books.FirstOrDefault(n => n.id == bookid); //GET por id
        public Book UpdateBookByID(int bookid, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);
            if(_book != null)
            {
                _book.Titulo = book.Titulo;
                _book.Descripcion = book.Descripcion;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.DateRead;
                _book.Rate = book.Rate;
                _book.Genero = book.Genero;
                _book.Autor = book.Autor;
                _book.CoverURL = book.CoverURL;

                _context.SaveChanges();
            }
            return _book;
        }
        public void DeleteBookById(int bookid)
        {
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);
            if (_book != null)
            {
                _context.Books.Remove( _book );
                _context.SaveChanges();
            }
        }
    }
}
