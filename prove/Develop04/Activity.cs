namespace mindfulness
{
    public class Activity
    {
        // public string ReflectingActivity()
        // {
        //     string _name = "Reflecting";
        //     string _description = "This activity will help you reflect on times ...";
        //     int _duration = 50;
        //     return "";
        //     // Set other values here that are unique to the Reflecting Activity
        // }
        public static void DisplayStartingMessage(string activity)
        {
            Console.WriteLine($"\nWelcome to the {activity} Activity!");
        }
        public static void DisplayEndingMessage(string activity, int seconds)
        {
            Console.WriteLine("\nGreat job!");
            Thread.Sleep(1000);
            Console.WriteLine($"You have just completed the {activity} activity in {seconds} seconds!\n");
            Thread.Sleep(5000);
        }
        public static void ShowSpinner(int seconds)
        {
            List<string> animationStrings = new List<string>
            {
                "|", "/", "-", "\\", "|", "/", "-", "\\"
            };
            int i = 0;
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);
            while (DateTime.Now < endTime)
            {
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
                i++;
                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
            }
        }
        public static void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        public static void ShowDots(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
        }
        public static void GetReady()
        {
            Console.WriteLine("OK get ready!");
            ShowCountDown(5);
        }
    }
}