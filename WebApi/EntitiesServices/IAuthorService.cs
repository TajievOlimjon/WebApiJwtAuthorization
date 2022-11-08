using WebApi.BaseServices;
using WebApi.Entities.EntitieDtos;

namespace WebApi.EntitiesServices
{
    public interface IAuthorService:IBaseService<AuthorDto>
    {
        Task<List<AuthorDto>> GetAuthorAsync();
        Task<AuthorDto> GetAuthorByNameAsync(AuthorDto author);
        Task<List<GetBookAuthorDto>> GetBookAuthors();
    }
}
