public class Word
{
    private bool _isHidden;
    private string _wordText;

    // constructor that takes in the word 
    public Word(string word)
    {
        _wordText = word;
    }

    // method to check if the word is hidden
    public bool IsHiddent()
    {
        return _isHidden;
    }

    // method to hide the word
    public void Hide()
    {

    }

    // method to display the word, either hidden or not
    public void Display()
    {
        
    }
}