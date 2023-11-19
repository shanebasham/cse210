public class Entry
{
    public string _entry;
    public DateTime _date;
    public string _prompt;

    public object Date { get; internal set; }
    public object Prompt { get; internal set; }
    public object Response { get; internal set; }

    public void Display()
    {
        List<Entry> entries = new List<Entry>();
        foreach (Entry todayEntry in entries) 
        {
            Console.WriteLine(todayEntry);
        }
    }
}