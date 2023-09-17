using AutoMapper;
using Skeleton.BLL.Interfaces;
using Skeleton.BLL.Models;
using Skeleton.BLL.Models.AddModels;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.BLL.Services;

public class QuestionService : IQuestionService
{
    private readonly IMapper _mapper;
    private readonly IQuestionRepository _questionRepository;

    public QuestionService(IQuestionRepository questionRepository, IMapper mapper)
    {
        _mapper = mapper;
        _questionRepository = questionRepository;
    }

    public async Task<IEnumerable<QuestionModel>> GetQuestionsByTestIdAsync(Guid testId)
    {
        var questions = await _questionRepository.GetAllByTestIdAsync(testId);

        return _mapper.Map<IEnumerable<QuestionModel>>(questions);
    }

    public async Task AddQuestionAsync(AddQuestionModel questionModel)
    {
        var mapper = _mapper.Map<Question>(questionModel);

        await _questionRepository.AddAsync(mapper);
    }

    public async Task UpdateQuestionAsync(UpdateQuestionModel questionModel)
    {
        var mapper = _mapper.Map<Question>(questionModel);

        await _questionRepository.UpdateAsync(mapper);
    }

    public async Task DeleteQuestionAsync(Guid id)
    {
        await _questionRepository.DeleteAsync(id);
    }
}