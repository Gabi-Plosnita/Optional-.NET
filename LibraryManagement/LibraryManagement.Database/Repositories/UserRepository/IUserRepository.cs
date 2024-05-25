using LibraryManagement.Database.Entities;

namespace LibraryManagement.Database.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);

        User GetByEmail(string email);

        List<User> GetAll();

        User Get(int id);

        void Update(int id, User updatedUser);

        void Delete(int id);
    }
}
