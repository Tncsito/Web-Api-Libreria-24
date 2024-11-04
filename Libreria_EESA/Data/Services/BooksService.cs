using libreria_EESA.Data;
using libreria_EESA.Data.Models;
using Libreria_EESA.Data.ViewModels;
using System;

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
            var _book = Book()
            {

            }
        }

        private object Book()
        {
            throw new NotImplementedException();
        }
    }
}
