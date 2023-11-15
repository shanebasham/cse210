using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            string userResponse = Console.ReadLine();
            number = int.Parse(userResponse);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int integer in numbers)
        {
            sum += integer;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];
        foreach (int integer in numbers)
        {
            if (integer > largest)
            {
                largest = integer;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}