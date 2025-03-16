using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Lecture l1 = new Lecture("Bob the Builder", "35", "Building Made Easy", "A lecture on how to build a simple house using talking tools.", "3/20/2025", "11am", "I-Center");
        Console.WriteLine(l1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(l1.FullDetails());
        Console.WriteLine();
        Console.WriteLine(l1.ShortDescription());
        Console.WriteLine();

        Reception r1 = new Reception("helamanT@email.com", "Wedding", "My fake wedding!", "1/1/3000", "1pm", "111 Southview Dr Harmony PA");
        Console.WriteLine(r1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(r1.FullDetails());
        Console.WriteLine();
        Console.WriteLine(r1.ShortDescription());
        Console.WriteLine();

        OutdoarGathering g1 = new OutdoarGathering("The weather will be rainy.", "Dancing in the Rain", "We will be dancing in the rain for some reason. I guess some people will find this enjoyable.", "April 7 2025", "10am", "Rigby Park");
        Console.WriteLine(g1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(g1.FullDetails());
        Console.WriteLine();
        Console.WriteLine(g1.ShortDescription());
        Console.WriteLine();
    }
}