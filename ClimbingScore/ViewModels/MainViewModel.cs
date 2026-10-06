using ClimbingScore.Commands;
using ClimbingScore.Models;
using ClimbingScore.Services;
using PropertyChanged;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ClimbingScore.ViewModels;

[AddINotifyPropertyChangedInterface]
public class MainViewModel
{
    public string ClimberName { get; set; } = "Erik";

    public ObservableCollection<ProblemViewModel> Problems { get; } = [];
    public bool IsLoading { get; private set; } = false;

    public ProblemViewModel? SelectedProblem { get; set; }

    public ICommand RegisterScoreCommand { get; }

    private readonly ProblemService _problemService;

    // smaka smet
    // https://www.instagram.com/reels/DPD5whLDIZe/


    public MainViewModel()
    {
        _problemService = new ProblemService();
        // var problems = _problemService.GetProblemsAsync().Result;

        //var problems = GetProblemsAsync().Result;

        //Problems = new ObservableCollection<ProblemViewModel>(
        //    problems.Select(CreateProblemViewModel));



        // SelectedProblem = Problems[0];

        RegisterScoreCommand =
            new RelayCommand(
                _ => RegisterScore());
    }

    private void RegisterScore()
    {
    }


    public async Task LoadAsync()
    {
        IsLoading = true;

        try
        {
            var problems = await _problemService.GetProblemsAsync();

            foreach (var problem in problems)
            {
                Problems.Add(CreateProblemViewModel(problem));
            }

            SelectedProblem = Problems[0];
        }
        finally
        {
            IsLoading = false;
        }
    }



    private async Task<IReadOnlyList<Problem>> GetProblemsAsync()
    {
        return await _problemService.GetProblemsAsync();
    }

    private ProblemViewModel CreateProblemViewModel(Problem problem)
    {
        return new ProblemViewModel
        {
            Number = problem.Number,
            Type = problem.Type,
            Grade = problem.Grade
        };
    }
}
