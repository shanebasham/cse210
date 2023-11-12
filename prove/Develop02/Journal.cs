using System.ComponentModel;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _todayEntry;
    public string _file;

    //display all entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("Date: {entry.Date}");
            Console.WriteLine("Prompt: {entry.Prompt}");
            Console.WriteLine("Response: {entry.Response}");
        }
    }

    //add entry
    public void AddEntry(_todayEntry Entry)
    {
        return "";
    }

    //save to file
    public void SaveToFile(string file)
    {
        Console.WriteLine('Please enter the file name here: ');
    }

    public void LoadFromFile(string file)
    {

    }
}