using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.DAL.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(QuizHubDatabaseContext dbContext) : base(dbContext)
    {
    }

    public async Task<User> GetUserByCredentialsAsync(string name, string password)
    {
        var result = await _dbContext.Users
            .FirstOrDefaultAsync(x => x.Name == name && x.Password == password);
                
        return result;
    }
}