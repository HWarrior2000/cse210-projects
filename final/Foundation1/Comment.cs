using System.Text.Encodings.Web;

public class Comment
{
    private string _text;
    private string _name;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void AddComment()
    {
        Console.Write("Add name: ");
        _name = Console.ReadLine();
        Console.Write("Add text: ");
        _text = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"\nUser Name: {_name}\nComment: {_text}");
    }
}
