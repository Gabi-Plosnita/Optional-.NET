using LibraryManagement.Database.Entities;

namespace LibraryManagement.Database.Repositories
{
    public interface IRoleRepository
    {
        List<Role> GetAll();

        Role Get(int id);

        void Create(Role role);

        void Update(int id, Role updatedRole);

        void Delete(int id);
    }
}
