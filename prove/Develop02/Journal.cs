using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entry.GetAnswer();
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry journalEntry in _entries)
        {
            journalEntry.Display();
        }
    }

    // this needs to be explained so i can remember what i did.
    public void SaveToFile (string file)
    {
        // make a list that has scope for the whole method
        List<string> existingEntries = new List<string>();

        // make sure the file exists before attempting to read from it
        if (File.Exists(file))
        {
            // read the file and add the lines to the existingEntries list that has scope to the rest of the method
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                existingEntries.Add(line);
            }
        }
        using (StreamWriter outputFile = new StreamWriter(file, true))
        {
            foreach (Entry journalEntry in _entries)
            {
                // this is checking to make sure that it isn't a duplicate entry this is my extra thing
                string entry = $"{journalEntry._date}~|~{journalEntry._prompt}~|~{journalEntry._userEntry}";
                if (!existingEntries.Contains(entry))
                {
                    outputFile.WriteLine(entry);
                }
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            while (!File.Exists(file))
            {
                Console.Write("Please enter a valid file, or type 1 to exit file selection: ");
                file = Console.ReadLine();
                if (file == "1")
                {
                    return;
                }
            }
        }
        _entries.Clear();
        string[] entryData = System.IO.File.ReadAllLines(file);
        foreach (string data in entryData)
        {
            string[] parts = data.Split("~|~");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._userEntry = parts[2];
            _entries.Add(newEntry);
        }
    }
}