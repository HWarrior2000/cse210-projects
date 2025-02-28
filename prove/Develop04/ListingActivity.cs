public class ListingActivity : Activity
{
    List<string> _originalPrompts;
    List<string> _secondaryPrompts;
    public ListingActivity() : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing Activity")
    {
        _originalPrompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        _secondaryPrompts = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    }
    public void Run()
    {
        ShowIntro();
        ShowEnding();
    }
}