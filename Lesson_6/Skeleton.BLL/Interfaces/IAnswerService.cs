using Skeleton.BLL.Models;
using Skeleton.BLL.Models.AddModels;

namespace Skeleton.BLL.Interfaces;

public interface IAnswerService
{
    public Task AddAnswerAsync(AddAnswerModel answerModel);
    public Task UpdateAnswerAsync(UpdateAnswerModel answerModel);
    public Task DeleteAnswerAsync(Guid id);
    public Task<IEnumerable<AnswerModel>> GetAnswersByQuestionIdAsync(Guid questionId);
    public Task<bool> CheckAnswerByIdAsync(Guid id);
    
    // todo: Add CRUD functions - done
}