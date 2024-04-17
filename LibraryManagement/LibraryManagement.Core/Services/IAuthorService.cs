using LibraryManagement.Core.Dtos.Request;

namespace LibraryManagement.Core.Services
{
    public interface IAuthorService
    {
        List<AuthorRequestDto> GetAuthors();
    }
}
