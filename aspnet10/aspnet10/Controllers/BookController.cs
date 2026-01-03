using aspnet10.Model;
using aspnet10.Repositories;
using aspnet10.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly ILogger<BookController> _logger;

        public BookController(IBookService bookService, ILogger<BookController> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }


        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Getting all books");
            return Ok(_bookService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] long id)
        {
            _logger.LogInformation("Getting book ID: {id}", id);

            var book = _bookService.FindById(id);
            if (book != null)
            {
                return Ok(book);
            }
            _logger.LogWarning("Book not found: {id}", id);
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            _logger.LogInformation("Creating book");
            var createdBook = _bookService.Create(book);
            if (createdBook == null)
            {
                _logger.LogWarning("Book could not be created");
                return BadRequest();
            }
            return Ok(createdBook);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Book book)
        {
            _logger.LogInformation("Updating book ID: {id}", book.Id);
            var updatedBook = _bookService.Update(book);
            if (updatedBook == null)
            {
                _logger.LogWarning("Book not found: {id}", book.Id);
                return NotFound();
            }
            return Ok(updatedBook);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] long id)
        {
            _logger.LogInformation("Deleting book ID: {id}", id);
            _bookService.Delete(id);
            return NoContent();
        }
    } 
}
