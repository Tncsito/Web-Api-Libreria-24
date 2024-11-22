using Libreria_EESA.Data.Services;
using Libreria_EESA.Data.ViewModels;
using Libreria_EESA.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;

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
            try
            {
                var newPublisher = _publisherService.AddPublisher(publisher);
                return Created(nameof(AddPublisher), newPublisher);
            }
            catch(PublisherNameException ex)
            {
                return BadRequest($"{ex.Message}, Nombre de la editora: {ex.PublisherName}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpGet("get-publisher-by-id/{id}")]
        public IActionResult GetPublisherById(int id)
        {
            var _response = _publisherService.GetPublisherById(id);
            if (_response == null)
            {
                return Ok( _response );
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("get-publisher-books-with-authors/{id}")]
        public IActionResult GetPublisherData(int id)
        {
            var _response = _publisherService.GetPublisherData(id);
            return Ok( _response );
        }
        [HttpDelete("delete-publisher-by-id/{id}")]
        public IActionResult DeletePublisherById(int id)
        {
            
            try
            {
                _publisherService.DeletePublisherById(id);
                return Ok();
            } 
            catch (Exception ex)
            {
                return BadRequest( ex.Message );
            }
        }
    }
}
