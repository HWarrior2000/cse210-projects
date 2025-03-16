public class Reception : Event
{
    private string _email;
    public Reception(string email, string title, string description, string date, string time, string address) : base("Reception", title, description, date, time, address)
    {
        _email = email;
    }
    public string FullDetails()
    {
        return $"{_title}\n{_description}\nRSVP: {_email}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }
}