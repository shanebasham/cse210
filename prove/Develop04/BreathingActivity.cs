namespace mindfulness
{
    public class BreathingActivity : Activity
    {
        public static void Run()
        {  
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.WriteLine("Please enter how many seconds you would like your session to be: ");
        }
        public static void BreatheIn()
        {
                Console.WriteLine("\nBreathe in...");
                Thread.Sleep(5000);
        }
        public static void BreatheOut()
        {
                Console.WriteLine("Breathe out...\n");
                Thread.Sleep(7000);
        }
    }
}