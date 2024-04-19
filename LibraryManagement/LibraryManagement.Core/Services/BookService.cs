using LibraryManagement.Core.Dtos.Request;
using LibraryManagement.Core.Mapping;
using LibraryManagement.Database.Repositories;

namespace LibraryManagement.Core.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public int CreateBook(BookRequestDto book)
        {
            int id = _bookRepository.CreateBook(book.ToBook());
            return id;
        }
    }
}
