using ClimbingScore.Commands;
using ClimbingScore.Models;
using PropertyChanged;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ClimbingScore.ViewModels;

[AddINotifyPropertyChangedInterface]
public class MainViewModel
{
    public MainViewModel()
    {
        RegisterScoreCommand = new RelayCommand(
            _ => RegisterScore(),
            _ => ProblemNumber >= 1
            );
        IncreaseAttemptsCommand = new RelayCommand(
            _ => Attempts++
            );
        DecreaseAttemptsCommand = new RelayCommand(
            _ => Attempts--,
            _ => Attempts > 1
            );
    }

    public int Attempts { get; set; } = 1;
    public string Name { get; set; } = "Erik";
    public bool IsEnabled { get; set; } = false;
    public int ProblemNumber { get; set; }
    public ObservableCollection<GradeColors> GradeColors { get; set; } =
        new(Enum.GetValues<GradeColors>());
    public GradeColors SelectedGrade { get; set; }
    public ICommand RegisterScoreCommand { get; }
    public ICommand IncreaseAttemptsCommand { get; }
    public ICommand DecreaseAttemptsCommand { get; }

    public GradeColors DefaultGradeColor { get; set; } = Models.GradeColors.Yellow;

    // public event PropertyChangedEventHandler? PropertyChanged;

    //protected void OnPropertyChanged(
    //       [CallerMemberName] string? propertyName = null)
    //{
    //    PropertyChanged?.Invoke(
    //        this,
    //        new PropertyChangedEventArgs(propertyName)
    //    );
    //}

    public void RegisterScore()
    {

        IsEnabled = true;
        Name = "Ahmed";
    }
}
