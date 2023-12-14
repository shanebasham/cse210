class Receptions : Event
{
    private string RsvpEmail { get; }
    public Receptions(string title, string description, DateTime date, string time, string street, string city, string rsvpEmail)
        : base(title, description, date, time, street, city)
    {
        RsvpEmail = rsvpEmail;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {RsvpEmail}";
    }
}