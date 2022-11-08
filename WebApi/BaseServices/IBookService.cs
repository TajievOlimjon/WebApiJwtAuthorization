using System.Net;
using WebApi.Entities;
using WebApi.Entities.EntitieDtos;

namespace WebApi.BaseServices
{
    public interface IBookService:IBaseService<BookDto>
    {
        Task<List<BookDto>> GetBooks();
        Task<BookDto> GetBookById(Guid id);
    }
}
