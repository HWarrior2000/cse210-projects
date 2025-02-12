using System.Collections.Immutable;
using System.Linq;
public class Word
{
    private bool _isHidden;
    private string _wordText;

    // constructor that takes in the word 
    public Word(string word)
    {
        _wordText = word;
        _isHidden = false;
    }

    // method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // method to hide the word
    public void Hide()
    {
        // looked up if there was an equivelant to map and it turns out that this is the best way to do it.
        // you make a string from an aray of characters that are make with the .Select method with the argument to turn them into '_'
        _wordText = new string(_wordText.Select(x => '_').ToArray());
        _isHidden = true;
    }

    // method to display the word, either hidden or not
    public string Display()
    {
        return _wordText;
    }
}