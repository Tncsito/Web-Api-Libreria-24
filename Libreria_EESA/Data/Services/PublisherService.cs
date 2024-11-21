using libreria_EESA.Data;
using Libreria_EESA.Data.Models;
using Libreria_EESA.Data.ViewModels;
using System;

namespace Libreria_EESA.Data.Services
{
    public class PublisherService
    {
        private AppDbContext _context;
        public PublisherService(AppDbContext context)
        {
            _context = context;
        }
        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
    }
}
