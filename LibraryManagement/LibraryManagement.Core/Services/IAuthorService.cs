using LibraryManagement.Core.Dtos.Response;
using LibraryManagement.Core.Dtos.Request;

namespace LibraryManagement.Core.Services
{
    public interface IAuthorService
    {
        List<AuthorResponseDto> GetAuthors();

        void CreateAuthor(AuthorRequestDto author);
    }
}
