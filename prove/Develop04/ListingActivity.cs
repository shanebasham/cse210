namespace mindfulness
{
    public class ListingActivity : Activity
    {
        public int _count;
        // _prompts : List<string> 
        // public string List<Word> _prompts;
        private readonly Random _random = new Random();
        public List<string> _prompts;
        public static void Run()
            {  
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine("Please enter how many seconds you would like your session to be: ");
            }
        public string GetRandomPrompt()
            {
                string[] prompts = new string[]
                {
                    "List some people in your life that you appreciate: ",
                    "List some of your personal strengths:",
                    "List some people that you have helped this week:",
                    "List some times that you felt the Holy Ghost this month:",
                    "List some of your personal heroes:"
                };
                int randomIndex = _random.Next(prompts.Length);
                return prompts[randomIndex];
            }
        // GetListFromUser() : List<string>
        public List<string> GetListFromUser()
            {
                return _prompts;
            }
    }
}