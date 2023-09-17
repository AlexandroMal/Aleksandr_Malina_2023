using System.Collections;
using AutoMapper;
using Skeleton.BLL.Interfaces;
using Skeleton.BLL.Models;
using Skeleton.BLL.Models.AddModels;
using Skeleton.DAL.Interfaces;
using Skeleton.DAL;
using Skeleton.DAL.Entities;

namespace Skeleton.BLL.Services;

public class AnswerService : IAnswerService
{
    private readonly IMapper _mapper;
    private readonly IAnswerRepository _answerRepository;

    public AnswerService(IAnswerRepository answerRepository, IMapper mapper)
    {
        _mapper = mapper;
        _answerRepository = answerRepository;
    }

    public async Task<IEnumerable<AnswerModel>> GetAnswersByQuestionIdAsync(Guid questionId)
    {
        var answers = await _answerRepository.GetAllByQuestionIdAsync(questionId);

        return _mapper.Map<IEnumerable<AnswerModel>>(answers);
    }

    public async Task<bool> CheckAnswerByIdAsync(Guid id)
    {
        var answer = await _answerRepository.CheckIsCorrectAsync(id);

        return answer;
    }

    public async Task AddAnswerAsync(AddAnswerModel answerModel)
    {
        var mapper = _mapper.Map<Answer>(answerModel);

        await _answerRepository.AddAsync(mapper);
    }
     
    public async Task UpdateAnswerAsync(UpdateAnswerModel answerModel)
    {
        var mapper = _mapper.Map<Answer>(answerModel);

        await _answerRepository.UpdateAsync(mapper);
    }

    public async Task DeleteAnswerAsync(Guid id)
    {
        await _answerRepository.DeleteAsync(id);
    }
}