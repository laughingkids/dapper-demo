using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Repository;



public class UserRepository : IUserRepository
{
    private readonly ISqlDataAccess _db;
    
    public UserRepository(ISqlDataAccess db)
    {
        _db = db;
    }
    
    public async Task<IEnumerable<UserModel>> GetUsers()
    {
        return await _db.LoadData<UserModel, dynamic>("dbo.spUser_GetAll", new {});
    }
    
    public async Task<UserModel?> GetUserById(Guid id)
    {
        var results = await _db.LoadData<UserModel, dynamic>(
            "dbo.spUser_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }
    
    public async Task InsertUser(UserModel user)
    {
        await _db.SaveData("dbo.spUser_Insert", new {user.Id, user.FirstName, user.LastName});
    }
    
    public async Task UpdateUser(UserModel user)
    {
        await _db.SaveData("dbo.spUser_Update", user);
    }
    
    public async Task DeleteUser(Guid id)
    {
        await _db.SaveData("dbo.spUser_Delete", new { Id = id });
    }
}