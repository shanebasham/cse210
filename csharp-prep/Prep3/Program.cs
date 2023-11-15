using System;

class Program
{
    static void Main(string[] args)
    {
        static void Game()
        {
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 101);
            int guess = -1;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    string yes;
                    Console.WriteLine("Would you like to play again?" );
                    yes = Console.ReadLine();
                    if (yes.StartsWith("y"))
                    {
                        Game();
                    }
                }
            }
        }
    }
}