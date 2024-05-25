using LibraryManagement.Database.Entities;

namespace LibraryManagement.Database.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetBooks();

        int CreateBook(Book book);
    }
}
