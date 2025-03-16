public class OutdoarGathering : Event
{
    private string _weather;
    public OutdoarGathering(string weather, string title, string description, string date, string time, string address) : base("Outdoar Gathering", title, description, date, time, address)
    {
        _weather = weather;
    }
    public string FullDetails()
    {
        return $"{_title}\n{_description}\n{_weather}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }
}