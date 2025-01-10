using DataAccess.Models;

namespace DataAccess.Repository;

public interface IUserRepository
{
    Task<IEnumerable<UserModel>> GetUsers();
    Task<UserModel?> GetUserById(Guid id);
    Task InsertUser(UserModel user);
    Task UpdateUser(UserModel user);
    Task DeleteUser(Guid id);
}