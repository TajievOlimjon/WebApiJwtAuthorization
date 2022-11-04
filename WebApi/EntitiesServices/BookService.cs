using Microsoft.EntityFrameworkCore;
using WebApi.BaseServices;
using WebApi.Data;
using WebApi.Entities;

namespace WebApi.EntitiesServices
{
    public class BookService : IBookService
    {   private readonly ApplicationContext _context;
        public BookService(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        public async Task<string> DeleteById(Guid Id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == Id);
                 _context.Books.Remove(book);
                 await _context.SaveChangesAsync();
                if (book == null) return $"Not deleted book:{Id}";
                return $"Deleted book :{book.Id} ,{book.Name}";
        }

        public async Task<Book> GetBookById(Guid id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return new Book();
            return book;
        }

       

        public List<Book> GetBooks()
        {
            return  _context.Books.ToList();
        }

        public async Task<string> Insert(Book entry)
        {
            entry.Id = Guid.NewGuid();
            await _context.Books.AddAsync(entry);
            var save = await _context.SaveChangesAsync();
            if (save.Equals(null)) return $"Not saved book:{entry.Name}";
            return $" Saved book:{entry.Name}";
        }

        public async Task<string> Update(Book entry)
        {
            var book = await _context.Books.FindAsync(entry.Id);
            book.Name = entry.Name;
            book.Descrption = entry.Descrption;
            await _context.SaveChangesAsync();
            if (book == null) return $"Not Updated {entry.Id}";
            return $"Updated book:{entry.Name},{entry.Descrption}";
        }
    }
}
