using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the mindfulness program!");
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start listening activity");
            Console.WriteLine("3. Start reflection activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
        }
    }
}