using LibraryManagement.Database.Context;

namespace LibraryManagement.Database.Repositories
{
    public class AuthorRepository : BaseRepository, IAuthorRepository
    {
        public AuthorRepository(LibraryDbContext libraryDbContext) : base(libraryDbContext)
        {
        }
    }
}
