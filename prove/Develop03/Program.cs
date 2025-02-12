using System;
using System.Diagnostics;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Helaman", 5, 12);
        Scripture scrip1 = new Scripture(reference1, "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");

        Console.Write($"{scrip1.DisplayScripture()}\n\nPress enter to continue or type 'quit' to finish: ");
        string userInput = GetValidUserInput();
        
        while (userInput != "quit" && !scrip1.IsAllHidden()){
            Console.Clear();
            scrip1.HideWord();
            Console.Write($"{scrip1.DisplayScripture()}\n\nPress enter to continue or type 'quit' to finish: ");
            userInput = GetValidUserInput();
        }
    }

    // function to get user input
    private static string GetValidUserInput()
    {
        string input = Console.ReadLine();
        while (input != "" && input != "quit")
            {
                Console.Write("Please try again: ");
                input = Console.ReadLine();
            }
        return input;
    }
}