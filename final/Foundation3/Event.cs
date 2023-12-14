class Event
{
    private string EventTitle {get; }
    private string EventDescription {get; }
    private DateTime EventDate {get; }
    private string EventTime {get; }
    private Address EventAddress {get; }
    public Event(string title, string description, DateTime date, string time, string street, string city)
    {
        EventTitle = title;
        EventDescription = description;
        EventDate = date;
        EventTime = time;
        EventAddress = new Address(street, city);
    }
    public virtual string GetStandardDetails()
    {
        return $"Title: {EventTitle}\nDescription: {EventDescription}\nDate: {EventDate.ToShortDateString()}\nTime: {EventTime}\nAddress: {EventAddress.GetFormattedAddress()}";
    }
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
    public virtual string GetShortDescription()
    {
        return $"Type: Event\nTitle: {EventTitle}\nDate: {EventDate.ToShortDateString()}";
    }
}