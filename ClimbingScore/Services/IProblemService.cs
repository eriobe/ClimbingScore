using ClimbingScore.Models;

namespace ClimbingScore.Services;

public interface IProblemService
{
    IReadOnlyList<Problem> GetProblems();
    Task<IReadOnlyList<Problem>> GetProblemsAsync();
}