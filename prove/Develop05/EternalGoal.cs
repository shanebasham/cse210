public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
    }
    public override void RecordEvent()
    {
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}

// EternalGoal(name : string, description : string, points : int)
// None needed
// RecordEvent() : void (Override)
// IsComplete() : bool (Override)
// GetStringRepresentation() : string (Override)