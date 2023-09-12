using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.DAL.Repositories;

public class TestRepository : BaseRepository<Test>, ITestRepository
{
    public TestRepository(QuizHubDatabaseContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<Test>> GetTestsByUserIdAsync(Guid userId)
    {
        var test = await _dbContext.Tests
            .Where(x => x.CreatedForUserId == userId)
            .ToListAsync();

        return test;
    }

    public async Task<Test> GetByIdWithQuestionsAsync(Guid id)
    {
        var test = await _dbContext.Tests
            .Include(x => x.Questions)
            .FirstOrDefaultAsync(x => x.Id == id);

        return test;
    }

    public async Task<string> GetDescriptionAsync(Guid id)
    {
        var description = await _dbContext.Tests
            .FirstOrDefaultAsync(x => x.Id == id);

        return description.Description;
    }
}