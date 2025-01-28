public class Entry
{
    PromptGenerator prompt1 = new PromptGenerator();
    public string _prompt;
    public string _date = DateTime.Today.ToString("d");
    public string _userEntry;


    // Generate prompt after prompt1 is initialized
    public Entry()
    {
        _prompt = prompt1.GeneratePrompt();
    }

    // give user the prompt and get their response
    public void GetAnswer()
    {
        Console.Write($"{_prompt}\n> ");
        _userEntry = Console.ReadLine();
        // fix this so that if the user doesn't enter anything it wont save or will have the user try to enter content again.
    }

    // return the formated entry as a string
    public string Display()
    {
        return ($"Date: {_date} - Prompt: {_prompt}\n{_userEntry}\n\n");
    }
}