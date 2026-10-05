using ClimbingScore.Commands;
using ClimbingScore.Models;
using PropertyChanged;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ClimbingScore.ViewModels;

[AddINotifyPropertyChangedInterface]
public class ProblemViewModel
{
    public int Number { get; set; }

    public string Type { get; set; } = "Slab";

    public GradeColor Grade { get; set; }

    public ObservableCollection<GradeColor> GradeColors { get; } =
        new(Enum.GetValues<GradeColor>());

    [AlsoNotifyFor(nameof(Score), nameof(ResultType))]
    public int Attempts { get; set; } = 1;

    public string ResultType =>
        Attempts == 1 ? "Flash" : "Redpoint";

    public int Score => CalculateScore();

    public ICommand IncreaseAttemptsCommand { get; }
    public ICommand DecreaseAttemptsCommand { get; }

    public ProblemViewModel()
    {
        IncreaseAttemptsCommand =
            new RelayCommand(
                _ => Attempts++);

        DecreaseAttemptsCommand =
            new RelayCommand(
                _ => Attempts--,
                _ => Attempts > 1);
    }

    private int CalculateScore()
    {
        int baseScore = Grade switch
        {
            GradeColor.Green => 100,
            GradeColor.Blue => 200,
            GradeColor.Yellow => 300,
            GradeColor.Red => 400,
            GradeColor.Black => 500,
            GradeColor.White => 600,
            _ => 0
        };

        if (Attempts == 1)
            return (int)(baseScore * 1.2);

        return baseScore;
    }
}


