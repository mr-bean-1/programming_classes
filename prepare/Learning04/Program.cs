using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Assignment a1 = new Assignment("James Bond", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Henry Cavill", "Fraction", "8.2", "6-12");
        Console.WriteLine(a2.GetSummary); 
        Console.WriteLine(a2.GetHomeworkList());
        WritingAssignment a3 = new MathAssignment("Abraham Lincoln", "American History", "The battle of Midway");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
