public class SimpleGoal : Goal
{
    // private bool _isComplete = false;
      public SimpleGoal(string name, string description, int points) : base (name, description, points)
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

// SimpleGoal(name : string, description : string, points : int) - This should also set the the variables for if it is complete to be false.
// RecordEvent() : void (Override)
// IsComplete() : bool (Override)
// GetStringRepresentation() : string (Override)