using Books.ApiAsync.Entities;

namespace Books.ApiAsync.Services;

public interface IBooksRepository
{
    Task<IEnumerable<Book>> GetBooksAsync();
    Task<Book?> GetBookAsync(Guid id);
}
