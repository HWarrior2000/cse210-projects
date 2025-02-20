using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment num1 = new Assignment("Helaman Tillotson", "Algebra");
        Console.WriteLine(num1.GetSummary());
        Console.WriteLine();

        MathAssignment math1 = new MathAssignment("Joshua", "Calculus", "7.1", "1-10");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
        Console.WriteLine();
    }
}