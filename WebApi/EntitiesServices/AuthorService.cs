using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Entities;
using WebApi.Entities.EntitieDtos;

namespace WebApi.EntitiesServices
{
    public class AuthorService : IAuthorService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public AuthorService(ApplicationContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<string> DeleteById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AuthorDto>> GetAuthorAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AuthorDto> GetAuthorByNameAsync(AuthorDto author)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetBookAuthorDto>> GetBookAuthors()
        {
            var query = await (from b in _context.Books
                               join ba in _context.BookAuthors on b.Id equals ba.BookId
                               join a in _context.Authors on ba.AuthorId equals a.Id
                               select new GetBookAuthorDto
                               {
                                   AuthorId=a.Id,
                                   FirstName=a.FirstName,
                                   LastName=a.LastName,
                                   MiddleName=a.MiddleName,
                                   Age=a.Age,
                                   Email=a.Email,
                                   Address=a.Address,
                                   BirthDate=a.BirthDate,
                                   BookId=b.Id,
                                   Name=b.Name,
                                   Descrption=b.Descrption
                                   

                               }).ToListAsync();
            return query;
        }

        public async Task<string> Insert(AuthorDto entry)
        {
            var mapped = _mapper.Map<Author>(entry);
               // mapped.Id = Guid.NewGuid();
            await _context.Authors.AddAsync(mapped);

            var save= await _context.SaveChangesAsync();

             if (save.Equals(null)) return $"Not saved book:{entry.FirstName}";
             return $" Saved book:{entry.FirstName}";
            
         }

        public Task<string> Update(AuthorDto entry)
        {
            throw new NotImplementedException();
        }
    }
}
