using libreria_EESA.Data;
using Libreria_EESA.Data.Models;
using Libreria_EESA.Data.ViewModels;
using System;

namespace Libreria_EESA.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }
        public void AddAuthor(AuthorsVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}
