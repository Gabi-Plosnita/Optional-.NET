using LibraryManagement.Database.Entities;

namespace LibraryManagement.Core.Services
{
    public interface IAuthenticationService
    {
        string GenerateToken(User user);
    }
}
