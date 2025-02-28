public class ListingActivity : Activity
{
    private List<string> _prompts;
    public ListingActivity() : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing Activity")
    {
        _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    }
    public void Run()
    {
        Random rnd = new Random();
        ShowIntro();
        Console.Write($"Consider the following prompt:\n --- {_prompts[rnd.Next(_prompts.Count)]} --- \nYou may begin in: ");
        ShowCountdown(5);
        DateTime futureTime = DateTime.Now.AddSeconds(_time);
        int total = 0;

        Console.WriteLine();
        do
        {
            Console.Write($"> ");
            Console.ReadLine();
            total++;
        } while (futureTime >= DateTime.Now);
        Console.WriteLine($"You listed {total} items!");

        ShowEnding();
    }
}