using Libreria_EESA.Data.Services;
using Libreria_EESA.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Libreria_EESA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;
        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }
        [HttpPost("add-book")]
        public IActionResult Addbook([FromBody]BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();
        }
    }
}
