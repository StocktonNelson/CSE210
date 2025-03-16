using System.Drawing;

public abstract class Goals
{
    private static List<Goals> _goals = new List<Goals>();
    private string _goalName;
    private string _description;
    private int _Goalpoints;
    private static int _Totalpoints;
    private bool _complete = false;

    public Goals(string name, string description, int Goalpoints){
        _goalName = name;
        _description = description;
        _Goalpoints = Goalpoints;
        _goals.Add(this);
    }

    public virtual bool IsComplete()
    {
        return _complete;
    }

    public virtual void RecordEvent()
    {
        _complete = true;
    }

    public virtual string Getgoal(){
        string checkbox = _complete ? "[X]" : "[ ]";
        return $"{checkbox} {_goalName} ({_description})";
    }

    public string GetName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual void AddPoints(){
        Console.WriteLine($"Good job, you have earned {_Goalpoints} points");
        _Totalpoints = _Goalpoints + _Totalpoints;
    }

    public virtual void AddPoints(int points){
        Console.WriteLine($"Good job, you have earned {points} points");
        _Totalpoints = points + _Totalpoints;
    }

    public static int GetTotalPoints()
    {
        return _Totalpoints;
    }

    public static void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            // First line: Total points
            writer.WriteLine(_Totalpoints);
            
            // Write each goal on a separate line
            foreach (var goal in _goals)
            {
                // Format: GoalType:Name:Description:Points:IsCompleted
                string goalType = goal.GetType().Name;
                string name = goal.GetName();
                string description = goal.GetDescription();
                int points = goal._Goalpoints;
                bool isCompleted = goal.IsComplete();
                
                // Additional data for checklist goals
                if (goal is Checklist checklistGoal)
                {
                    int bonusPoints = checklistGoal.GetBonusPoints();
                    int steps = checklistGoal.GetSteps();
                    int stepsCompleted = checklistGoal.GetStepsCompleted();
                    
                    writer.WriteLine($"{goalType}:{name}:{description}:{points}:{isCompleted}:{bonusPoints}:{steps}:{stepsCompleted}");
                }
                else
                {
                    writer.WriteLine($"{goalType}:{name}:{description}:{points}:{isCompleted}");
                }
            }
        }
    }

    public static void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }
        
        // Clear existing goals
        _goals.Clear();
        
        using (StreamReader reader = new StreamReader(fileName))
        {
            // First line: Total points
            string totalPointsLine = reader.ReadLine();
            if (int.TryParse(totalPointsLine, out int totalPoints))
            {
                _Totalpoints = totalPoints;
            }
            
            // Read each line and create appropriate goal objects
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                
                if (parts.Length >= 5)
                {
                    string goalType = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isCompleted = bool.Parse(parts[4]);
                    
                    Goals goal = null;
                    
                    switch (goalType)
                    {
                        case "Basic":
                            goal = new Basic(name, description, points);
                            break;
                        case "Eternal":
                            goal = new Eternal(name, description, points);
                            break;
                        case "Checklist":
                            if (parts.Length >= 8)
                            {
                                int bonusPoints = int.Parse(parts[5]);
                                int steps = int.Parse(parts[6]);
                                int stepsCompleted = int.Parse(parts[7]);
                                
                                goal = new Checklist(name, description, points, bonusPoints, steps);
                                
                                // Set steps completed
                                Checklist checklistGoal = (Checklist)goal;
                                checklistGoal.StepsCompleted(stepsCompleted);
                                
                                // Mark as complete if needed
                                if (stepsCompleted >= steps)
                                {
                                    checklistGoal.RecordEvent();
                                }
                            }
                            break;
                    }
                    
                    // Mark as complete if needed
                    if (goal != null && isCompleted && !(goal is Eternal))
                    {
                        goal._complete = true;
                    }
                }
            }
        }
        
        Console.WriteLine($"Goals loaded successfully. Total points: {_Totalpoints}");
    }

    public static void PrintAllGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }
        
        foreach (var goal in _goals)
        {
            if (goal is Checklist checklistGoal)
            {
                Console.WriteLine($"{goal.Getgoal()} -- Currently completed: {checklistGoal.GetStepsCompleted()}/{checklistGoal.GetSteps()}");
            }
            else
            {
                Console.WriteLine(goal.Getgoal());
            }
        }
    }

    public static List<Goals> GetIncompleteGoals()
    {
        List<Goals> incompleteGoals = new List<Goals>();

        foreach (var goal in _goals)
        {
            if (goal is Eternal || !goal.IsComplete())
            {
                incompleteGoals.Add(goal);
            }
        }

        return incompleteGoals;
    }
}
