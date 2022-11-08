using Microsoft.AspNetCore.Mvc;
using WebApi.BaseServices;
using WebApi.Entities;
using WebApi.Entities.EntitieDtos;

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
        public async Task<ActionResult> GetBooks()
        {
            var books = await _bookService.GetBooks();
            if (books == null) return BadRequest();
            return Ok(books);
        }

        [HttpGet("GetBookById")]
        public async Task<ActionResult> GetBookById(Guid id)
        {
            var book= await _bookService.GetBookById(id);
            if (book == null)return  BadRequest();
            return Ok(book);
        }

        [HttpPost("AddBook")]
        public async Task<ActionResult> Post([FromForm] BookDto book)
        {
            var b= await _bookService.Insert(book);
            if (b == null) return BadRequest();
            return Ok(b);
        }

        [HttpPut("EditBookById")]
        public async Task<ActionResult> Put([FromBody]BookDto book)
        {
            var b= await _bookService.Update(book);
            if (b == null) return BadRequest();
            return Ok(b);
        }

        [HttpDelete("DeleteBookById")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var b= await _bookService.DeleteById(id);
            if (b == null) return BadRequest();
            return Ok(b);
        }
    }
}
