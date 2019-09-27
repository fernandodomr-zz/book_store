using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;
using BookStore.Domain.Interfaces.Services;

namespace BookStore.Application
{
    public class BookAppService : AppServiceBase<Book>, IBookAppService
    {
        private readonly IBookService _bookService;

        public BookAppService(IBookService bookService) : base(bookService)
        {
            _bookService = bookService;
        }
    }
}
