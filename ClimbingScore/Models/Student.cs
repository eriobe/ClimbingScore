using System;
using System.Collections.Generic;
using System.Text;

namespace ClimbingScore.Models;

public class Student : ICanGreet
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string SayHello()
    {
        return "hej";
    }
}

public class Teacher : ICanGreet
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public string SayHello()
    {
        throw new NotImplementedException();
    }
}
