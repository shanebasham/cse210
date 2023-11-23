public class Entry
{

    public string _date { get; internal set; }
    public string _prompt { get; internal set; }
    public string _response { get; internal set; }

    public Entry(string dateText, string randomPrompt, string response)
    {
        _date = dateText;
        _prompt = randomPrompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");   
    }
}