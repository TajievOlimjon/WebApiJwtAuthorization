using Microsoft.AspNetCore.Mvc;
using WebApi.BaseServices;
using WebApi.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet("GetBooks")]
        public IActionResult GetBooks()
        {
           var books =  _bookService.GetBooks();
            return Ok(books);
        }

        [HttpGet("GetBookById")]
        public async Task<Book> GetBookById(Guid id)
        {
            return await _bookService.GetBookById(id);
        }

        [HttpPost("AddBook")]
        public async Task<string> Post([FromBody] Book book)
        {
            return await _bookService.Insert(book);
        }

        [HttpPut("EditBookById")]
        public async Task<string> Put([FromBody]Book book)
        {
            return await _bookService.Update(book);
        }

        [HttpDelete("DeleteBookById")]
        public async Task<string> Delete(Guid id)
        {
            return await _bookService.DeleteById(id);
        }
    }
}
