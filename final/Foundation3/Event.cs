public class Event
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string type, string title, string description, string date, string time, string address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
        return $"{_title}\n{_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    public string ShortDescription()
    {
        return $"Event Type: {_type}\n{_title}\nDate: {_date}";
    }
}