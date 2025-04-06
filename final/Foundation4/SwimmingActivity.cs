public class SwimmingActivity : Activity
{
    private double _lapNumber;

    public SwimmingActivity(string date, double minutes, double lap) : base(date, minutes, "Swimming")
    {
        _lapNumber = lap;
    }

    public override double GetDistance()
    {
        return _lapNumber * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}