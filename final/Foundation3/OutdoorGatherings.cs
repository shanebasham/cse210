class OutdoorGatherings : Event
{
    private string Weather {get; }

    public OutdoorGatherings(string title, string description, DateTime date, string time, string street, string city, string weather): base(title, description, date, time, street, city)
    {
        Weather = weather;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {Weather}";
    }
}