using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _startingMessage;
    private string _name;
    protected int _time;

    public Activity (string startingMessage, string name)
    {
        _startingMessage = startingMessage;
        _name = name;
    }

    protected void ShowIntro()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n\n{_startingMessage}\n");
        GetTime();
        Console.Clear();
    }

    private void GetTime()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());
    }

    protected void ShowCountdown(int seconds)
    {
        for (int second = seconds; second > 0; second--)
        {
            if (second != seconds)
            {
                if ((second + 1) < 10 && (second + 1) > 0)
                {
                    Console.Write("\b \b");
                }
                else if (((second + 1) / 10) < 10)
                {
                    Console.Write("\b\b  \b\b");
                }
            }
            Console.Write(second);
            Thread.Sleep(1000);
        }
        Console.Write("\b \b");
    }

    public void ShowSpinner(int seconds)
    {
        for (int amount = seconds; amount > 0; amount--)
        {
            for (int i = 4; i > 0; i--)
            {
                if (i == 4)
                {
                    Console.Write("|");
                }
                else if (i == 3)
                {
                    Console.Write("/");
                }
                else if (i == 2)
                {
                    Console.Write("-");
                }
                else if (i == 1)
                {
                    Console.Write("\\");
                }
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
        
    }

    protected void ShowEnding()
    {
        Console.WriteLine("\n\nWell done!!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed another {_time} seconds of the {_name}.");
        ShowSpinner(2);
    }
}