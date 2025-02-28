public class BreathingActivity : Activity
{
    public BreathingActivity () : base("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing Activity")
    {

    }

    public void Run()
    {
        ShowIntro();

        Console.WriteLine("Get ready...");
        ShowSpinner(2);

        int numReps = _time / 10;

        // this will run if their is an amount of time that isn't divisible by 10 before the other reps will run so that all of the time is taken correctly.
        if ((_time % 10) != 0)
        {
            int timeRemaning = _time % 10;
            Console.Write("\n\nBreathe in...");
            ShowCountdown((int)Math.Round(timeRemaning * .4));
            Console.Write("\nNow breathe out...");
            ShowCountdown((int)Math.Round(timeRemaning * .6));
        }
        
        // this will display all of the normal reps that need to run. None will display if they are not needed.
        NormalReps(numReps);

        ShowEnding();
    }

    private void NormalReps(int reps)
    {
        for (int i = reps; i > 0; i --)
            {
                Console.Write("\n\nBreathe in...");
                ShowCountdown(4);
                Console.Write("\nNow breathe out...");
                ShowCountdown(6);
            }
    }
}