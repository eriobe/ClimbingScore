using ClimbingScore.Commands;
using ClimbingScore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ClimbingScore.ViewModels;

public class MainViewModel
{
    public MainViewModel()
    {
        RegisterScoreCommand = new RelayCommand(
            _ => RegisterScore()
            );
    }
    public string Name { get; set; } = "Erik";
    

    public ICommand RegisterScoreCommand { get; }

    public void RegisterScore()
    {

    }

























    public void Test()
    {
        Student erik = new();

        Teacher eva = new();
        
    }

    public void Greet(ICanGreet member)
    {
        Name = member.SayHello();
    }
}
