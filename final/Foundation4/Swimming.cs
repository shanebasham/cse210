class Swimming : Activity
{
    private int Laps {get; }
    public Swimming(DateTime date, int durationInMinutes, int laps): base(date, durationInMinutes)
    {
        Laps = laps;
    }
    public override double GetDistance()
    {
        // 50 meters per lap convert to kilometers
        return Laps * 50 / 1000.0;
    }
    public override double GetSpeed()
    {
        return GetDistance() / (DurationInMinutes / 60.0);
    }
    public override double GetPace()
    {
        return DurationInMinutes / GetDistance();
    }
}