using System.Runtime.CompilerServices;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    // constructors
    public Reference()
    {
        _book = "1 Nephi";
        _chapter = "1";
        _startVerse = "1";
        _endVerse = "1";
    }
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }
    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // method for getting the reference
    public void GetReference()
    {
        
    }
}