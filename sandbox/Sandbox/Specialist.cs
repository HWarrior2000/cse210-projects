public class Specialist : Staff
{
    private string _specialty;

    public Specialist (string firstName, string lastName, string gender, string specialty) : base (firstName, lastName, gender)
    {
        _specialty = specialty;
    }

    public string GetGreeting() 
    {
        return $"Hello students, I am {_gender} {_lastName}. I am a {_specialty} specialist.";
    }
}