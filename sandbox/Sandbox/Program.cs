using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Teacher teach1 = new Teacher("Sarah", "Jones", "Mr.", 18);
        Console.WriteLine(teach1.GetGreeting());

        Specialist s1 = new Specialist("Sarah", "Brown", "Ms", "reading");
        Console.WriteLine(s1.GetGreeting());
    }
}