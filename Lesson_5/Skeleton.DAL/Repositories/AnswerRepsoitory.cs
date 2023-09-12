using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.DAL.Repositories;

public class AnswerRepository : BaseRepository<Answer>, IAnswerRepository
{
    public AnswerRepository(QuizHubDatabaseContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> CheckIsCorrectAsync(Guid id)
    {
        var result = await _dbContext.Answers
            .FirstOrDefaultAsync(x => x.Id == id);

        return result.IsCorrect;
    }

    public async Task<IEnumerable<Answer>> GetAllByQuestionIdAsync(Guid questionId)
    {
        var answers = await _dbContext.Answers
            .Where(x => x.QuestionId == questionId)
            .ToListAsync();

        return answers;
    }
}