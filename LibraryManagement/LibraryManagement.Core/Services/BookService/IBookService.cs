using LibraryManagement.Core.Dtos.Request;
using LibraryManagement.Core.Dtos.Response;

namespace LibraryManagement.Core.Services
{
    public interface IBookService
    {
        List<BookResponseDto>  GetBooks();

        int CreateBook(BookRequestDto book);
    }
}
