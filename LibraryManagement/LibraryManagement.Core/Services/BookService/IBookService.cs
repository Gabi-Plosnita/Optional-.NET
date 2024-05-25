using LibraryManagement.Core.Dtos.Request;

namespace LibraryManagement.Core.Services
{
    public interface IBookService
    {
        int CreateBook(BookRequestDto book);
    }
}
