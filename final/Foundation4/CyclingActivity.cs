public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, double minutes, double speed) : base(date, minutes, "Cycling")
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return GetSpeed() * (_minutes / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}