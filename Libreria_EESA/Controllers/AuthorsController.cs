using Libreria_EESA.Data.Services;
using Libreria_EESA.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Libreria_EESA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : Controller
    {
        private AuthorsService _authorsService;
        public AuthorsController(AuthorsService authorsService)
        {
            _authorsService = authorsService;
        }
        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorsVM author)
        {
            _authorsService.AddAuthor(author);
            return Ok();
        }
    }
}
