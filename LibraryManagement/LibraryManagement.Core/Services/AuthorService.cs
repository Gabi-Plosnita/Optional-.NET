using LibraryManagement.Core.Dtos.Response;
using LibraryManagement.Database.Repositories;

namespace LibraryManagement.Core.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        List<AuthorRequestDto> IAuthorService.GetAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
