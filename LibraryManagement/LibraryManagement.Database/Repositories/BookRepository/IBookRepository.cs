using LibraryManagement.Database.Entities;

namespace LibraryManagement.Database.Repositories
{
    public interface IBookRepository
    {
        int CreateBook(Book book);
    }
}
