using LibraryManagement.Database.Context;
using LibraryManagement.Database.Entities;

namespace LibraryManagement.Database.Repositories.RoleRepository
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(LibraryDbContext context) : base(context)
        {
        }
        public List<Role> GetAll()
        {
            return _libraryDbContext.Roles.ToList();
        }

        public Role Get(int id)
        {
            var role = _libraryDbContext.Roles.Find(id);
            if (role == null)
            {
                throw new Exception("Role not found");
            }
            return role;
        }

        public void Create(Role role)
        {
            if(_libraryDbContext.Roles.Any(r => r.Name == role.Name))
            {
                throw new Exception($"Role with name {role.Name} already exists");
            }
            _libraryDbContext.Roles.Add(role);
            SaveChanges();
        }

        public void Update(int id, Role updatedRole)
        {
            var role = _libraryDbContext.Roles.Find(id);
            if (role == null)
            {
                throw new Exception("Role not found");
            }

            if(_libraryDbContext.Roles.Any(r => r.Name == updatedRole.Name))
            {
                throw new Exception($"Role with name {updatedRole.Name} already exists");
            }

            role.Name = updatedRole.Name;
            SaveChanges();
        }

        public void Delete(int id)
        {
            var role = _libraryDbContext.Roles.Find(id);
            if (role == null)
            {
                throw new Exception("Role not found");
            }

            _libraryDbContext.Roles.Remove(role);
            SaveChanges();
        }
    }
}
