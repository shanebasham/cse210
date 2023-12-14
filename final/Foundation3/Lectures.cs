class Lectures : Event
{
    private string SpeakerName {get; }
    private int Capacity {get; }
    public Lectures(string title, string description, DateTime date, string time, string street, string city, string speakerName, int capacity): base(title, description, date, time, street, city)
    {
        SpeakerName = speakerName;
        Capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {SpeakerName}\nCapacity: {Capacity} attendees";
    }
}