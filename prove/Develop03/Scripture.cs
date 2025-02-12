public class Scripture
{
    private List<Word> words = new List<Word>();
    private Reference reference1;

    // constructor for getting a reference with the verses
    public Scripture(Reference theReference, string verses)
    {
        reference1 = theReference;
        string[] splitScripture = verses.Split(" ");
        foreach (string splitWord in splitScripture)
        {
            Word newWord = new Word(splitWord);
            words.Add(newWord);
        }
    }

    // method to hide 3 random words
    public void HideWord()
    {
        Random rnd = new Random();
        int i = 1;

        // doesn't check to see if its allready hidden
        // for (int i = 0; i < 3; i++)
        // {
        //     words[rnd.Next(words.Count())].Hide();
        // }

        // checks to make sure its hidden
        while (i <= 3 && !IsAllHidden())
        {
            int checkNum = rnd.Next(words.Count());
            if (!words[checkNum].IsHidden())
            {
                words[checkNum].Hide();
                i++;
            }
        }
    }

    //method to display the scripture
    public string DisplayScripture()
    {
        string finalOutput = reference1.GetReference();
        int counter = 0;
        foreach(Word i in words)
        {
            finalOutput += $"{i.Display()} ";
            counter++;
            if (counter == 15 || counter == 35 || counter == 55 || counter == 80 || counter == 110)
            {
                finalOutput += "\n";
            }
        }
        return finalOutput;
    }

    // method to check if all are hidden
    public bool IsAllHidden()
    {
        foreach (Word i in words)
        {
            if (!i.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}