// using System;

// namespace scripture_memorizer
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Alma 32:21 And now as I said concerning faith—afaith is not to have a perfect knowledge of things; therefore if ye have faith ye bhope for things which are cnot seen, which are true.");
//             Console.WriteLine("Press enter to continue, type quit to finish. ");
//             string quit = Console.ReadLine();
//             Console.Clear();
//             while (!quit.StartsWith("q"))
//                 {
//                     HideWords();
//                 }
//             Console.WriteLine("OK Goodbye!");
//             break;
//         }
//         static void HideWords()
//         {
//             Console.WriteLine("Works?");
//         }
//     }
// }

using System;


namespace scripture_memorizer
{
    public class Program
    {
        static void Main()
        {
            var scripture = new Scripture("Alma 32:21", "And now as I said concerning faith — faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
            // Console.Clear();
            Console.WriteLine(scripture.Reference);
            Console.WriteLine(scripture.Verse);

            while (true)
            {
                Console.Write("Press enter to continue, type quit to finish. ");
                string input = Console.ReadLine();

                if (input.StartsWith("q"))
                {
                    Console.WriteLine("OK Goodbye!");
                    break;
                }

                scripture.HideRandomWords(3);
                // Console.Clear();
                Console.WriteLine(scripture.Reference);
                Console.WriteLine(scripture.Verse);

                if (scripture.IsCompletelyHidden())
                {
                    break;
                }
            }
        }
    }
}





       


// Scripture
// _reference: Reference 
// _words : List<Word>

// Scripture(Reference : Reference, text : string)
// HideRandomWords(numberToHide: int) : void
// GetDisplayText() : string
// IsCompletelyHidden() : bool

// Reference
// _book: string 
// _chapter: int 
// _verse: int 
// _endVerse: int

// Reference(book : string, chapter: int, verse : int)
// Reference(book : string, chapter: int, startVerse : int, endVerse: int)
// GetDisplayText() : string

// Word
// _text : string 
// _isHidden: bool

// Word(text : string)
// Hide() : void




// using System;

// class MainClass {
//  public static void Main (string[] args) {
//     string input;
//     bool startWithQ = false;

//     while (!startWithQ) {
//       Console.WriteLine("Enter a text that does not start with \"while\":");
//       input = Console.ReadLine();

//       if (input == null || input.Trim().Length == 0) {
//         Console.WriteLine("Invalid input. Please enter a non-empty string.");
//       } else if (input.StartsWith("while", StringComparison.OrdinalIgnoreCase)) {
//         Console.WriteLine("Invalid input. Text starts with \"while\".");
//       } else {
//         startWithQ = true;
//       }
//     }

//     Console.WriteLine("Your input: \"{0}\"", input);
//  }
// }