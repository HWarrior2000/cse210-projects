public class Entry
{
    PromptGenerator prompt1 = new PromptGenerator();
    public string _prompt;
    public string _date;
    public string _userEntry;

    // give user the prompt and get their response
    public void GetAnswer()
    {
        _date = DateTime.Today.ToString("d");
        _prompt = prompt1.GeneratePrompt();
        Console.Write($"{_prompt}\n> ");
        _userEntry = Console.ReadLine();
        // make sure the user enters a response
        while(_userEntry == "")
            {
                Console.Write("Please enter a response:\n>");
                _userEntry = Console.ReadLine();
            }
    }

    // return the formated entry as a string
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_userEntry}\n");
    }
}