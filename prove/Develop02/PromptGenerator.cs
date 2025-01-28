public class PromptGenerator
{
    // my current list
    // eventually have it pull this list from a file
    public List<string> _prompts = new List<string>
    {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};

    // get a random number generator
    public Random randomGenerator = new Random();


    // randomely pick a prompt
    public string GeneratePrompt()
    {
        int number = randomGenerator.Next(_prompts.Count);
        return _prompts[number];
    }

    // make a method to write a new prompt to a pre determened file

    // in the PromptGenerator() set the _prompts = to the contents of a file in a list
}
