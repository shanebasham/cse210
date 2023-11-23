using System.ComponentModel;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _todayEntry;
    public string _file;

    //display all entries
    public void DisplayAll()
    {
        foreach (Entry _todayEntry in _entries)
        {
            _todayEntry.Display();
            Console.WriteLine("------------------------------------");
        }
    }

    //add entry
    public void AddEntry(Entry _todayEntry)
    {
        _entries.Add(_todayEntry);
    }

    //save to file
    public static void SaveToFile(string file)
    {
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (var entry in outputFile)
            {
                entry.Display();
            }
        }
        Console.WriteLine("Entry saved successfully! ");
    }

    //load from file
    public static List<Entry> LoadFromFile(string file)
    {
        List<Entry> fileEntries = new List<Entry>();
        Console.WriteLine("Please enter the file name here: ");
        file = Console.ReadLine(); 
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        return fileEntries;
    }
}