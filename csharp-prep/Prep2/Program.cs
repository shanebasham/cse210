using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade here: ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You have a {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congradulations you passed the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}