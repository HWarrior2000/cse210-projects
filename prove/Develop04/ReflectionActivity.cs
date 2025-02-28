public class ReflectionActivity : Activity
{
    private List<string> _originalPrompts;
    private List<string> _secondaryPrompts;
    public ReflectionActivity() : base("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflection Activity")
    {
        _originalPrompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        _secondaryPrompts = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    }
    public void Run()
    {
        Random rnd = new Random();
        ShowIntro();

        // display the random original prompt
        Console.WriteLine($"Consider the following prompt:\n\n --- {_originalPrompts[rnd.Next(_originalPrompts.Count)]} --- \n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        ShowCountdown(5);
        Console.Clear();

        if (_time < 10)
        {
            Console.Write($"> {_secondaryPrompts[rnd.Next(_secondaryPrompts.Count)]} ");
            ShowSpinner(_time);
            Console.WriteLine();
        }
        else
        {
            //display the secondary prompts
            int reps = _time / 10;
            // this is getting the amount of time to wait between reps
            int timeToWait = (int)Math.Round(((double)(_time % 10)) / reps);
            for (int i = reps; i > 0; i --)
                {
                    Console.Write($"> {_secondaryPrompts[rnd.Next(_secondaryPrompts.Count)]} ");
                    ShowSpinner(timeToWait + 10);
                    Console.WriteLine();
                }            
        }
        
        ShowEnding();
    }
}