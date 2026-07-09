/*===============================================================
    FILE: Journal.cs
    PURPOSE: stores ALL journal entries
    Every journal can: Add, display, save, load, search, delete, dashboard

=================================================================*/

using System.IO;

public class Journal
{
    /* Saves all journal entries */
    public List<Entry> _entries = new List<Entry>();


    /*---------- Add Entry ----------*/

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }


    /*---------- Display Journal ----------*/

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    /*---------- Save Journal ----------*/

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }


    /*---------- Load Journal ----------*/

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
    }

    public void DeleteEntry(int entryNumber)
    {
        int index = entryNumber - 1;

        if (index >= 0 && index < _entries.Count)
        {
            _entries.RemoveAt(index);
            Console.WriteLine("Entry deleted.");
        }
        else
        {
            Console.WriteLine("That entry number does not exist.");
        }
    }

}
