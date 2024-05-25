using LibraryManagement.Database.Entities;

namespace LibraryManagement.Database.Repositories
{
    public interface IAuthorRepository
    {
        List<Author> GetAuthors(); 

        int CreateAuthor(Author author);
    }
}
