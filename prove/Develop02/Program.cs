using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoise = "";
        Journal activeJournal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");
        do
        {
            // get the users input and verify that it is a valid answer
            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nwhat would you like to do? ");
            userChoise = Console.ReadLine();
            while(userChoise != "1" && userChoise != "2" && userChoise != "3" && userChoise != "4" && userChoise != "5")
            {
                Console.Write("Please enter a valid response: ");
                userChoise = Console.ReadLine();
            }

            // complete action requested by user
            // get new entry and add it to the entries list
            if(userChoise == "1")
            {
                Entry newEntry = new Entry();
                activeJournal.AddEntry(newEntry);
            }

            // display the entries
            else if(userChoise == "2")
            {
                activeJournal.DisplayAll();
            }

            // load entries from the file 
            else if(userChoise == "3")
            {
                Console.Write("Please enter a file name: ");
                string fileName = Console.ReadLine() + ".txt";
                activeJournal.LoadFromFile(fileName);
            }

            // save entries to a file
            else if(userChoise == "4")
            {
                Console.Write("Please enter a file name: ");
                string fileName = Console.ReadLine() + ".txt";
                activeJournal.SaveToFile(fileName);
            }

            //say goodby
            else if(userChoise == "5")
            {
                Console.WriteLine("Goodbye");
            }
        }while(userChoise != "5");
    }
}