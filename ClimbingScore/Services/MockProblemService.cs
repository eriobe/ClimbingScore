using ClimbingScore.Models;

namespace ClimbingScore.Services;

public class MockProblemService : IProblemService
{

    public async Task<IReadOnlyList<Problem>> GetProblemsAsync()
    {

        await Task.Delay(1);
        return new List<Problem>
        {
            new()
            {
                Number = 1,
                Type = "Överhäng",
                Grade = GradeColor.Green
            },
            new()
            {
                Number = 2,
                Type = "Slab",
                Grade = GradeColor.Blue
            },
            new()
            {
                Number = 3,
                Type = "Vertikal",
                Grade = GradeColor.Yellow
            },
            new()
            {
                Number = 4,
                Type = "Överhäng",
                Grade = GradeColor.Red
            }
        };
    }

    public IReadOnlyList<Problem> GetProblems()
    {
        return new List<Problem>
        {
            new()
            {
                Number = 1,
                Type = "Överhäng",
                Grade = GradeColor.Green
            },
            new()
            {
                Number = 2,
                Type = "Slab",
                Grade = GradeColor.Blue
            },
            new()
            {
                Number = 3,
                Type = "Vertikal",
                Grade = GradeColor.Yellow
            },
            new()
            {
                Number = 4,
                Type = "Överhäng",
                Grade = GradeColor.Red
            }
        };
    }
}

