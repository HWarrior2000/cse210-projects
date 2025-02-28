public class ReflectionActivity : Activity
{
    public ReflectionActivity() : base("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflection Activity")
    {

    }
    public void Run()
    {
        ShowIntro();
        ShowEnding();
    }
}