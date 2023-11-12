using System;

class Program
{
    static void Main(string[] args)
    {
        // new entry
        // display journal entries
        // load journal from file
        // provide a menu
        // list of prompts - 5 prompts
        // 1-What did you learn today?
        // 2-What's one thing that made you smile today?
        // 3-What are three things you were grateful for today?
        // 4-What is one problem or challenge you faced today and how did you overcome it?
        // 5-Write down three things you have accomplished today, no matter how small


        // welcome to the journal program!
        // please select one of the following:
        // menu: 
        List<Entry> entries = new List<Entry>();

        foreach (Entry todayEntry in entries) 
        {
            Console.WriteLine(todayEntry);
        }
    }
}