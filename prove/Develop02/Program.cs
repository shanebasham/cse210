using System;
using System.Reflection;
using System.Transactions;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the journal program!");
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display All Journal Entries");
            Console.WriteLine("3. Load Journal From File");
            Console.WriteLine("4. Save Journal To File");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("OK here is your prompt of the day!");
                PromptGenerator generator = new PromptGenerator();
                string randomPrompt = generator.GenerateRandomPrompt();
                Console.WriteLine(randomPrompt);
                string response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Entry entry = new Entry(dateText, randomPrompt, response);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter file name here: ");
                string file = Console.ReadLine();
                List<Entry> fileEntries = Journal.LoadFromFile(file);
                foreach (Entry entry in fileEntries)
                {
                    Console.WriteLine(entry);
                }
            }
            else if (choice == "4")
            {
                Journal SaveToFile = new Journal();
                Console.WriteLine(SaveToFile);
            }
            else if (choice == "5")
            {
                Console.WriteLine("OK Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Please enter one of the 5 numbers.");
            }
        }
    }
}