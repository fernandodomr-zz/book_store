using BookStore.Domain.Entities;
using BookStore.Domain.Interfaces.Repositories;
using BookStore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Services
{
    public class BookService : ServiceBase<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository) : base(bookRepository)
        {
            _bookRepository = bookRepository;
        }
    }
}
