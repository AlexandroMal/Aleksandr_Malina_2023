using AutoMapper;
using Skeleton.BLL.Interfaces;
using Skeleton.BLL.Models;
using Skeleton.BLL.Models.AddModels;
using Skeleton.DAL.Interfaces;
using Skeleton.DAL;
using Skeleton.DAL.Entities;

namespace Skeleton.BLL.Services;

public class TestService : ITestService
{
    private readonly ITestRepository _testRepository;
    private readonly IMapper _mapper;

    public TestService(ITestRepository testRepository, IMapper mapper)
    {
        _testRepository = testRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<string>> GetTestsByUserIdAsync(Guid userId)
    {
        var testsId = (await _testRepository.GetTestsByUserIdAsync(userId))
                  .Select(test => test.Id.ToString());

        return testsId;
    }

    public async Task<TestModel> GetTestWithQuestionsAsync(Guid id)
    {
        var tests = await _testRepository.GetByIdWithQuestionsAsync(id);

        return _mapper.Map<TestModel>(tests);
    }

    public async Task<string> GetTestDescriptionAsync(Guid id)
    {
        return await _testRepository.GetDescriptionAsync(id);

    }

    public async Task DeleteTestAsync(Guid id)
    {
        await _testRepository.DeleteAsync(id);
    }

    public async Task AddTestAsync(AddTestModel model)
    {
        var mapper = _mapper.Map<Test>(model);

        await _testRepository.AddAsync(mapper);
    }

    public async Task UpdateTestAsync(UpdateTestModel model)
    {
        var test = await _testRepository.GetWithQuestionsAndAnswerAsync(Guid.Parse(model.Id));
        var mapper = _mapper.Map(model, test);
        await _testRepository.UpdateAsync(mapper);

    }
}