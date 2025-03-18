using Books.ApiAsync.DbContexts;
using Books.ApiAsync.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books.ApiAsync.Services
{
    public class BooksRepository : IBooksRepository
    {

        private readonly BooksContext _context;

        public BooksRepository(BooksContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Book?> GetBookAsync(Guid id)
        {
            return await _context.Books.Include(b => b.Author).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await _context.Books.Include(b => b.Author).ToListAsync();
        }
    }
}