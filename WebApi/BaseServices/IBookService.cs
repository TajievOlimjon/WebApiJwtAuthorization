using System.Net;
using WebApi.Entities;

namespace WebApi.BaseServices
{
    public interface IBookService:IBaseService<Book>
    {
        List<Book> GetBooks();
        Task<Book> GetBookById(Guid id);
    }
}
