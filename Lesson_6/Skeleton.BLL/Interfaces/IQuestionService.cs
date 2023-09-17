using Skeleton.BLL.Models;
using Skeleton.BLL.Models.AddModels;

namespace Skeleton.BLL.Interfaces;

public interface IQuestionService
{
    public Task<IEnumerable<QuestionModel>> GetQuestionsByTestIdAsync(Guid testId);
    public Task AddQuestionAsync(AddQuestionModel questionModel);
    public Task UpdateQuestionAsync(UpdateQuestionModel questionModel);
    public Task DeleteQuestionAsync(Guid id);
    
    // todo: add CRUD functions - done
}