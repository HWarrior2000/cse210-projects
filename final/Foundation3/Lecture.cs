public class Lecture : Event
{
    private string _speaker;
    private string _capacity;
    public Lecture(string speaker, string capacity, string title, string description, string date, string time, string address) : base("Lecture", title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string FullDetails()
    {
        return $"{_title}\n{_description}\nSpeaker: {_speaker}\nCapacity: {_capacity}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }
}