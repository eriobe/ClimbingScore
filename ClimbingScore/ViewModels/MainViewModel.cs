using ClimbingScore.Commands;
using ClimbingScore.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ClimbingScore.ViewModels;

public class MainViewModel
{
    public string ClimberName { get; set; } = "Erik";

    public ObservableCollection<ProblemViewModel> Problems { get; } =
        new()
        {
            new ProblemViewModel
            {
                Number = 1,
                Type = "Överhäng",
                Grade = GradeColor.Green
            },
            new ProblemViewModel
            {
                Number = 2,
                Grade = GradeColor.Blue
            },
            new ProblemViewModel
            {
                Number = 3,
                Grade = GradeColor.Yellow
            },
            new ProblemViewModel
            {
                Number = 4,
                Grade = GradeColor.Red
            }
        };

    public ProblemViewModel? SelectedProblem { get; set; }

    public ICommand RegisterScoreCommand { get; }

    public MainViewModel()
    {
        SelectedProblem = Problems[0];

        RegisterScoreCommand =
            new RelayCommand(
                _ => RegisterScore());
    }

    private void RegisterScore()
    {
    }
}
