using System;
using System.Reflection;
using System.Transactions;

public class Program
{
    static void Main(string[] args)
    {

        // static void DisplayMenu()
        // {
            Console.WriteLine("Welcome to the journal program!");
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display All Journal Entries");
            Console.WriteLine("3. Load Journal From File");
            Console.WriteLine("4. Save Journal To File");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("OK here is your prompt of the day!");
                PromptGenerator generator = new PromptGenerator();
                string randomPrompt = generator.GenerateRandomPrompt();
                Console.WriteLine(randomPrompt);
            }
            else if (choice == 2)
            {
                Journal DisplayAll = new Journal();
                Console.WriteLine(DisplayAll);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter file name here: ");
                string file = Console.ReadLine();
                List<Entry> fileEntries = Journal.LoadFromFile(file);
                foreach (Entry entry in fileEntries)
                {
                    Console.WriteLine(entry);
                }
            }
            else if (choice == 4)
            {
                Journal SaveToFile = new Journal();
                Console.WriteLine(SaveToFile);
            }
            else if (choice == 5)
            {
                Console.WriteLine("OK Goodbye!");
            }
        //     else
        //     {
        //         Console.WriteLine("Please enter one of the 5 numbers.");
        //         DisplayMenu();
        //     }
        // }
    }
}