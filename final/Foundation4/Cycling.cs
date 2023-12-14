class Cycling : Activity
{
    private double Speed {get; }
    public Cycling(DateTime date, int durationInMinutes, double speed)
        : base(date, durationInMinutes)
    {
        Speed = speed;
    }
    public override double GetSpeed()
    {
        return Speed;
    }
    public override double GetDistance()
    {
        return Speed * (DurationInMinutes / 60.0);
    }
    public override double GetPace()
    {
        return 60.0 / Speed;
    }
}