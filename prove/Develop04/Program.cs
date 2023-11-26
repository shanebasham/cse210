using System;
namespace mindfulness
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the mindfulness program!");
                Console.WriteLine("Please select one of the following: ");
                Console.WriteLine("1. Start breathing activity");
                Console.WriteLine("2. Start listing activity");
                Console.WriteLine("3. Start reflecting activity");
                Console.WriteLine("4. Quit");
                Console.WriteLine("What would you like to do? ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Activity.DisplayStartingMessage("Breathing");
                    BreathingActivity.Run();
                    int seconds = int.Parse(Console.ReadLine());
                    Activity.GetReady();
                    DateTime startTime = DateTime.Now;
                    DateTime endTime = startTime.AddSeconds(seconds);
                    while (DateTime.Now < endTime)
                    {
                        BreathingActivity.BreatheIn();
                        Activity.ShowCountDown(5);
                        BreathingActivity.BreatheOut();
                        Activity.ShowCountDown(5);
                    }
                    Activity.DisplayEndingMessage("Breathing", seconds);
                }
                else if (choice == "2")
                {
                    Activity.DisplayStartingMessage("Listing");
                    ListingActivity.Run();
                    int seconds = int.Parse(Console.ReadLine());
                    Activity.GetReady();
                    ListingActivity generator = new ListingActivity();
                    string randomPrompt = generator.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);
                    Activity.ShowSpinner(seconds);
                    string response = Console.ReadLine();
                    Activity.DisplayEndingMessage("Listing", seconds);
                }
                else if (choice == "3")
                {
                    Activity.DisplayStartingMessage("Reflecting");
                    ReflectingActivity.Run();
                    int seconds = int.Parse(Console.ReadLine());
                    Activity.GetReady();
                    DateTime startTime = DateTime.Now;
                    DateTime endTime = startTime.AddSeconds(seconds);
                    while (DateTime.Now < endTime)
                    {
                        ReflectingActivity generator = new ReflectingActivity();
                        string randomPrompt = generator.GetRandomPrompt();
                        string randomQuestion = generator.GetRandomQuestion();
                        Console.WriteLine(randomPrompt);
                        Activity.ShowSpinner(15);
                        Console.WriteLine(randomQuestion);
                        Activity.ShowSpinner(15);
                    }
                    Activity.DisplayEndingMessage("Reflecting", seconds);
                }
                else if (choice == "4")
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
}