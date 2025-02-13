using System.ComponentModel.Design;
using System.Net;

public class Book
{
    private string _title;
    private string _author;
    private string _checkOutDate;

    public Book(string title, string author)
    {
        _title = title;
        _author = author;
        _checkOutDate = "";
    }

    public void CheckOut()
    {
        _checkOutDate = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public bool IsCheckedOut()
    {
        return _checkOutDate != "";
    }

    public void Display()
    {
        if(IsCheckedOut())
        {
            Console.WriteLine($"{_title} by {_author} checked out: {_checkOutDate}");
        }
        else
        {
            Console.WriteLine($"{_title} by {_author} has not been checked out");
        }
    }
}