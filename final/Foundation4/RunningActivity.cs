public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, double minutes, double distance) : base(date, minutes, "Running")
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}