public class PromptGenerator
    {
        private readonly Random _random = new Random();
        public string GenerateRandomPrompt()
        {
            string[] prompts = new string[]
            {
                "What did you learn today?", 
                "What's one thing that made you smile today?", 
                "What are three things you were grateful for today?", 
                "What is one problem or challenge you faced today and how did you overcome it?", 
                "Write down three things you have accomplished today, no matter how small.", 
                "What is something someone said today that stuck out to you?", 
                "What did you do today to get out of your comfort zone and grow?"
            };

            int randomIndex = _random.Next(prompts.Length);
            return prompts[randomIndex];
        }
    }
