using BookStore.Domain.Entities;
using BookStore.Domain.Interfaces.Repositories;

namespace BookStore.Infra.Data.Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
    }
}
