using System.Runtime.CompilerServices;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // constructors
    // public Reference()
    // {
    //     _book = "1 Nephi";
    //     _chapter = 1;
    //     _startVerse = 1;
    //     _endVerse = 1;
    // }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // method for getting the reference
    public string GetReference()
    {
        if (_startVerse != _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse} ";
        } 
        else
        {
            return $"{_book} {_chapter}:{_startVerse} ";
        }
    }
}