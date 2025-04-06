public abstract class Activity
{
    protected string _date;
    protected double _minutes;
    protected string _activityType;
    
    public Activity(string date, double minutes, string type)
    {
        _date = date;
        _minutes = minutes;
        _activityType = type;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date} {_activityType} ({_minutes} min)- Distance {Math.Round(GetDistance(), 1)} miles, Speed {Math.Round(GetSpeed(), 1)} mph, Pace: {Math.Round(GetPace(), 1)} min per mile";
    }
}