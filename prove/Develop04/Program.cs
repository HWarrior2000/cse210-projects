using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        do
        {
            Console.Clear();
            Console.Write("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                BreathingActivity b1 = new BreathingActivity();
                b1.Run();
            }
            else if (userChoice == "2")
            {
                ReflectionActivity r1 = new ReflectionActivity();
                r1.Run();
            }
            else if (userChoice == "3")
            {
                ListingActivity l1 = new ListingActivity();
                l1.Run();
            }
        } while(userChoice != "4");
    }
}