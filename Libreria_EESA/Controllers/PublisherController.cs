using Libreria_EESA.Data.Services;
using Libreria_EESA.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Libreria_EESA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : Controller
    {
        private PublisherService _publisherService;
        public PublisherController(PublisherService publisherService)
        {
            _publisherService = publisherService;
        }
        [HttpPost("add-publisher")]
        public IActionResult AddPublisher([FromBody] PublisherVM publisher)
        {
            _publisherService.AddPublisher(publisher);
            return Ok();
        }
    }
}
