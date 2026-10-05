namespace ClimbingScore.Models;

public class Problem
{
    public int Number { get; set; }

    public string Type { get; set; } = "";

    public GradeColor Grade { get; set; }
}
