using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.BaseServices;
using WebApi.Data;
using WebApi.Entities;
using WebApi.Entities.EntitieDtos;

namespace WebApi.EntitiesServices
{
    public class BookService : IBookService
    {   
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public BookService(ApplicationContext applicationContext,IMapper mapper)
        {
            _context = applicationContext;
            _mapper = mapper;
        }

        public async Task<string> DeleteById(Guid Id)
        {
           var book = 
                await _context.Books.FirstOrDefaultAsync(x => x.Id == Id);
                 _context.Books.Remove(book);
                 await _context.SaveChangesAsync();
                if (book == null) return $"Not deleted book:{Id}";
                return $"Deleted book :{book.Id} ,{book.Name}";
        }

        public async Task<BookDto> GetBookById(Guid id)
        {
            var book = await (from b in _context.Books
                              where b.Id == id
                              select new BookDto
                              {
                                  Id = b.Id,
                                  Name = b.Name,
                                  Descrption = b.Descrption,
                                  AddressPublisher = b.AddressPublisher,
                                  QuantityPublishedBook = b.QuantityPublishedBook,
                                  PublishedDate = b.PublishedDate,
                                  CreateDate=b.CreateDate,
                                  UpdateDate=b.UpdateDate
                              }).FirstOrDefaultAsync();                         
            
            return book;
        }

       

        public async Task<List<BookDto>> GetBooks()
        {
            var books=await _context.Books.ToListAsync();
            var mapped = _mapper.Map<List<BookDto>>(books);
            return mapped;
        }

        public async Task<string> Insert(BookDto entry)
        {
           // entry.Id = Guid.NewGuid();
            var mapped = _mapper.Map<Book>(entry);
            await _context.Books.AddAsync(mapped);
            var save = await _context.SaveChangesAsync();
            if (save.Equals(null)) return $"Not saved book:{entry.Name}";
            return $" Saved book:{entry.Name}";
        }

        public async Task<string> Update(BookDto entry)
        {
            var mapped = _mapper.Map<Book>(entry);

            var book = await _context.Books.FindAsync(mapped.Id);

            book.Name = entry.Name;
            book.Descrption = entry.Descrption;
            book.Descrption = entry.Descrption;
            book.AddressPublisher = entry.AddressPublisher;
            book.QuantityPublishedBook = entry.QuantityPublishedBook;
            book.PublishedDate = entry.PublishedDate;
            book.CreateDate = entry.CreateDate;
            book.UpdateDate = entry.UpdateDate;

            await _context.SaveChangesAsync();

            if (book == null) return $"Not Updated {entry.Id}";
            return $"Updated book:{entry.Name},{entry.Descrption}";
        }
    }
}
