using System.ComponentModel;
using System.IO;

public class GoalManager
{
    public int _score;
    public List<Goal> _goals = new List<Goal>();
    public string _newGoal;
    public string _file;

    //initializes and empty list of goals and sets the player's score to be 0
    // public GoalManager()
    // {
    //     int _score = 0;
    // }
    //display players current score
    public void DisplayPlayerInfo(int _score)
    {
        Console.WriteLine($"\nYou have {_score} points! Keep up the great work!");
    }
    //display all goals
    public void ListGoalNames()
    {
        foreach (Goal _newGoal in _goals)
        {
            // _newGoal.Display();
            // Console.WriteLine("------------------------------------------");
        }
    }
    //lists the details of each goal (including the checkbox of whether it is complete)
    public void DisplayPlayerDetails()
    {

    }
    //asks the user for the information about a new goal. Then, creates the goal and adds it to the list
    public void CreateGoal(Goal _newGoal)
    {
        _goals.Add(_newGoal);
    }
    //asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal
    public void RecordEvent()
    {

    }
    //save goals to file
    public static void SaveGoals(string file)
    {
        // using(StreamWriter outputFile = new StreamWriter(file))
        // {
        //     foreach (var entry in outputFile)
        //     {
        //         entry.Display();
        //     }
        // }
        // Console.WriteLine("Entry saved successfully! ");
    }

    //load goals from file
    public static List<Goal> LoadFromFile(string _file)
    {
        List<Goal> fileGoals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(_file);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        return fileGoals;
    }
}

// In addition to the goal classes, the GoalManager class will need to keep track of the list of goals as well as the players score.
// GoalManager() - Initializes and empty list of goals and sets the player's score to be 0.
// _goals : List<Goal>
// _score : int
// In addition to these behaviors for the goals, the goal manager class will need behaviors related to the menu system such as the following:
// Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
// DisplayPlayerInfo - Displays the players current score.
// ListGoalNames - Lists the names of each of the goals.
// ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
// CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
// RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
// SaveGoals - Saves the list of goals to a file.
// LoadGoals - Loads the list of goals from a file.