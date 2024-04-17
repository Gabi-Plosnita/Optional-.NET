using LibraryManagement.Core.Dtos.Response;

namespace LibraryManagement.Core.Services
{
    public interface IAuthorService
    {
        List<AuthorResponseDto> GetAuthors();
    }
}
