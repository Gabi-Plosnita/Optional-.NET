using LibraryManagement.Core.Dtos.Request;
using LibraryManagement.Core.Dtos.Response;

namespace LibraryManagement.Core.Services
{
    public interface IRoleService
    {
        List<RoleResponseDto> GetAll();

        RoleResponseDto Get(int id);

        void Create(RoleRequestDto roleDto);

        void Update(int id, RoleRequestDto updatedRoleDto);

        void Delete(int id);
    }
}
