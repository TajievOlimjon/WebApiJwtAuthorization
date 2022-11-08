

using Microsoft.AspNetCore.Mvc;
using WebApi.Entities.EntitieDtos;
using WebApi.EntitiesServices;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController:ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost("AddAuthor")]
        public async Task<ActionResult> Create(AuthorDto author)
        {
            var a = await _authorService.Insert(author);
            if (a == null) return BadRequest();
            return Ok(a);
        }

        [HttpGet("GetBookAuthors")]
        public async Task<ActionResult> GetBookAuthors()
        {
            var b = await _authorService.GetBookAuthors();
            if (b == null) return BadRequest();
            return Ok(b);
        }
    }
}
