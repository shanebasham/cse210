public class ChecklistGoal : Goal
{
    // private int _amountCompleted;
    // private int target;
    // private int bonus;
          public ChecklistGoal(string name, string description, int points) : base (name, description, points)
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

// CheckListGoal(name : string, description : string, points : int, target : int, bonus : int) - In addition to the standard attributes, a checklist goal also needs the target and the bonus amounts. Then, it should set the amount completed to begin at 0.
// _amountCompleted : int
// _target : int
// _bonus : int
// RecordEvent() : void (Override)
// IsComplete() : bool (Override)
// GetDetailsString() : string (Override)
// GetStringRepresentation() : string (Override)