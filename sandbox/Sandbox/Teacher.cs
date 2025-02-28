public class Teacher : Staff
{
    private int _roomNum;

    public Teacher (string firstName, string lastName, string gender, int roomNum) : base (firstName, lastName, gender)
    {
        _roomNum = roomNum;
    }

    public string GetGreeting() 
    {
        return $"Hello students, I am {_gender} {_lastName}. I teach in room {_roomNum}.";
    }
}