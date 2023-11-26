namespace mindfulness
{
    public class ReflectingActivity : Activity
    {
        private readonly Random _random = new Random();
        public List<string> _prompts;
        public List<string> _questions;
        public static void Run()
            {  
                Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine("Please enter how many seconds you would like your session to be: ");
            }
        public string GetRandomPrompt()
            {
                string[] prompts = new string[]
                {
                    "\nThink of a time when you stood up for someone else.",
                    "\nThink of a time when you did something really difficult.",
                    "\nThink of a time when you helped someone in need.",
                    "\nThink of a time when you did something truly selfless."
                };
                int randomIndex = _random.Next(prompts.Length);
                return prompts[randomIndex];
            }
        public string GetRandomQuestion()
            {
                string[] prompts = new string[]
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };
                int randomIndex = _random.Next(prompts.Length);
                return prompts[randomIndex];
            }
        public void DisplayPrompt()
            {

            }
        public void DisplayQuestions()
            {

            }
    }
}