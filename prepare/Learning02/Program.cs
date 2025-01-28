using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menu:\n1. Add new job\n2. Display resume\n3. Quit\n");
    }
    static void Main(string[] args)
    {
        Resume theResume = new Resume();
        string userChoise = "";
        do{
            DisplayMenu();
            Console.Write("Enter choice: ");
            userChoise = Console.ReadLine();
            while(userChoise != "1" && userChoise != "2" && userChoise != "3")
            {
                Console.Write("Please enter a valid response: ");
                userChoise = Console.ReadLine();
            }

            if (userChoise == "1")
            {
                // Add a new job
                Job theJob = new Job();

                Console.Write("what is the name of the commpany? ");
                theJob._company = Console.ReadLine();

                Console.Write("What is the position? ");
                theJob._jobTitle = Console.ReadLine();

                theJob._startYear = 2015;
                theJob._endYear = 2025;

                theResume._jobs.Add(theJob);

            }

            else if (userChoise == "2")
            {
                // Display the resume
                theResume.DisplayResume();
            }
        }while(userChoise != "3");
    }
}