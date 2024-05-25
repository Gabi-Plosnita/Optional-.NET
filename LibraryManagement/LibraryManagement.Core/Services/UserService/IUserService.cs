using LibraryManagement.Core.Dtos.Request;
using LibraryManagement.Core.Dtos.Response;

namespace LibraryManagement.Core.Services
{
    public interface IUserService
    {
        void Register(UserRequestDto userRequestDto);

        string Login(LoginRequestDto loginDto);

        List<UserResponseDto> GetAll();

        UserResponseDto Get(int id);

        void Update(int id, UserRequestDto updatedUserDto);

        void Delete(int id);
    }
}
