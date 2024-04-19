using LibraryManagement.Database.Context;
using LibraryManagement.Database.Entities;

namespace LibraryManagement.Database.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public BookRepository(LibraryDbContext context) : base(context)
        {
        }

        public int CreateBook(Book book)
        {
            var author = _libraryDbContext.Authors.Find(book.AuthorId);

            if(author == null)
            {
                // Create middleware to handle exceptions
                throw new Exception("Author not found");
            }

            _libraryDbContext.Books.Add(book);
            _libraryDbContext.SaveChanges();

            return book.Id;
        }
    }
}
