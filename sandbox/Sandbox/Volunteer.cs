public class Volunteer : Staff
{

    public Volunteer (string firstName, string lastName, string gender) : base (firstName, lastName, gender)
    {
        
    }

    public string GetGreeting() 
    {
        return $"Hello students, I am {_gender} {_lastName}. I am a volunteer at the school.";
    }
}