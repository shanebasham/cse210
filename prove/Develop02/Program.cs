using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

        static void DisplayMenu()
        {
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
                List<string> prompts = new List<string> {"What did you learn today?", "What's one thing that made you smile today?", "What are three things you were grateful for today?", "What is one problem or challenge you faced today and how did you overcome it?", "Write down three things you have accomplished today, no matter how small.", "What is something someone said today that stuck out to you?", "What did you do today to get out of your comfort zone and grow?"};                  
                Random PromptGenerator new Random();
                int index = PromptGenerator.Next(1,6);
                string randomPrompt = prompts[index];
                Console.WriteLine(randomPrompt);
            }
            else if (choice == 2)
            {
                DisplayAll();
            }
            else if (choice == 3)
            {
                List<Entry> fileEntries = LoadFromFile();
                foreach (Entry entry in fileEntries)
                {
                    Console.WriteLine(entry);
                }
            }
            else if (choice == 4)
            {
                SaveToFile();
            }
            else if (choice == 5)
            {
                Console.WriteLine("OK Goodbye!");
            }
            else
            {
                Console.WriteLine("Please enter one of the 5 numbers.");
                DisplayMenu();
            }
        }
    }
}