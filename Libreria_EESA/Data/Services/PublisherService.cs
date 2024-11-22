using libreria_EESA.Data;
using Libreria_EESA.Data.Models;
using Libreria_EESA.Data.ViewModels;
using Libreria_EESA.Exceptions;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Libreria_EESA.Data.Services
{
    public class PublisherService
    {
        private AppDbContext _context;
        public PublisherService(AppDbContext context)
        {
            _context = context;
        }
        public Publisher AddPublisher(PublisherVM publisher)
        {
            if (StringStartsWithNumber(publisher.Name)) throw new PublisherNameException("El nombre empieza con un número",
                publisher.Name);
            var _publisher = new Publisher()
            {
                Name = publisher.Name
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
            return _publisher;
        }
        public Publisher GetPublisherById(int id) => _context.Publishers.FirstOrDefault(x => x.Id == id);
        public PublisherWithBooksAndAuthorsVM GetPublisherData(int publisherId)
        {
            var _publisherData = _context.Publishers.Where(n => n.Id == publisherId)
                .Select(n => new PublisherWithBooksAndAuthorsVM()
                {
                    Name=n.Name,
                    BookAuthors = n.Books.Select(n => new BookAuthorVM()
                    {
                        BookName = n.Titulo,
                        BooksAuthors = n.Book_Authors.Select(n => n.Author.FullName).ToList()
                    }).ToList()
                }).FirstOrDefault();
                return _publisherData;
        }
        internal void DeletePublisherById(int id)
        {
            var _publisher = _context.Publishers.FirstOrDefault(n => n.Id == id);
            if (_publisher != null)
            {
                _context.Publishers.Remove(_publisher);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception($"La editora con el id: {id} no existe!");
            }
        }
        private bool StringStartsWithNumber(string name) => (Regex.IsMatch(name, @"´^\d"));
    }
}
