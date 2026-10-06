using ClimbingScore.Services;
using ClimbingScore.ViewModels;
using System.Windows;

namespace ClimbingScore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            ProblemService problem = new();
            _viewModel = new MainViewModel(problem);
            DataContext = _viewModel;

            Loaded += MainWindow_Loaded;
            // mainViewModel.
            // injicera
            // 1 property
            // 2. Metodparameter
            // 3. Konstruktor
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.InitProblems();
        }
    }
}