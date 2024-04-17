using LibraryManagement.Database.Context;
using LibraryManagement.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Database.Repositories
{
    public class AuthorRepository : BaseRepository, IAuthorRepository
    {
        public AuthorRepository(LibraryDbContext libraryDbContext) : base(libraryDbContext)
        {
        }

        public List<Author> GetAuthors()
        {
            var result = _libraryDbContext.Authors
                .Include(a => a.Books)
                .AsNoTracking()
                .ToList();

            return result;
        }
    }
}
