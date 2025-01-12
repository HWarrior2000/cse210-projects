using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int grade = int.Parse(response);

        string leterGrade = "";

        if (grade >= 90)
        {
            leterGrade = "A";
        }

        else if (grade >= 80 && grade < 90)
        {
            leterGrade = "B";
        }

        else if (grade >= 70 && grade < 80)
        {
            leterGrade = "C";
        }

        else if (grade >= 60 && grade < 70)
        {
            leterGrade = "D";
        }

        else
        {
            leterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {leterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("You failed!");
        }
    }
}