namespace ClimbingScore.Models;

public class Score
{
    public string ClimberName { get; set; } = "";

    public int ProblemNumber { get; set; }

    public int Attempts { get; set; }

    public int Points { get; set; }
}