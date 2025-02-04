using System;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Display();
        p1.SetName("Jerry");
        p1.SetAge(23);

        p1.Display();

        string theName = p1.GetName();
        int theAge = p1.GetAge();

        Console.WriteLine($"The Persons name was: {theName} - {theAge}");
    }
}