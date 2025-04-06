using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        RunningActivity run = new RunningActivity("05 Apr 2025", 25, 1);
        activities.Add(run);
        CyclingActivity cycling = new CyclingActivity("06 Apr 2025", 60, 13);
        activities.Add(cycling);
        SwimmingActivity swimming = new SwimmingActivity("07 Apr 2025", 45, 10);
        activities.Add(swimming);

        foreach(Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}