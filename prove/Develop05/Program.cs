using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Goal Game!");
        while (true)
        {
            // int score = 0;
            // GoalManager.DisplayPlayerInfo(score);
            Console.WriteLine("\nPlease select one of the following: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("What would you like to do? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("\nSelect which kind of goal you would like to enter: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                string goalChoice = Console.ReadLine();
                if (goalChoice == "1")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("Give a short description: ");
                    string goalDescription = Console.ReadLine();
                    Console.WriteLine("How many points will you get when you achieve this goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());
                }
                else if (goalChoice == "2")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("Give a short description: ");
                    string goalDescription = Console.ReadLine();
                    Console.WriteLine("How many points will you get when you achieve this goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());
                }
                else if (goalChoice == "3")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("Give a short description: ");
                    string goalDescription = Console.ReadLine();
                    Console.WriteLine("How many points will you get when you achieve this goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many times do you want to accomplish this goal to receive a bonus? ");
                    string goalAmount = Console.ReadLine();
                    Console.WriteLine("How many bonus points will you get when you accomplish it that many times?");
                    int goalBonus = int.Parse(Console.ReadLine());
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Your goals are: ");
                // foreach (Goal goal in goals)
                // {
                //     Console.WriteLine(goal);
                // }
            }
            else if (choice == "3")
            {
                // GoalManager SaveToFile = new GoalManager();
                // Console.WriteLine(SaveToFile);
                Console.WriteLine("What is the filename of your goal file?");
                string filename = Console.ReadLine();
                Console.WriteLine($"Goals successfully saved to {filename}!");
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename of your goal file?");
                string filename = Console.ReadLine();
                GoalManager.LoadFromFile(filename);
                Console.WriteLine($"Goals successfully loaded from {filename}!");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Your goals are: ");
                // foreach (Goal goal in goals)
                // {
                //     Console.WriteLine(goal);
                // }
                Console.WriteLine("Which goal did you accomplish?" );
                int goalAccomplished = int.Parse(Console.ReadLine());
                Console.WriteLine("Which goal did you accomplish?" );

            }
            else if (choice == "6")
            {
                Console.WriteLine("Did you save your changes to a file?");
                string yes = Console.ReadLine();
                if (yes == "yes")
                {
                    Console.WriteLine("OK Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("OK save your changes!");
                }
            }
            else
            {
                Console.WriteLine("Please enter one of the 6 numbers.");
            }
        }
    }
}