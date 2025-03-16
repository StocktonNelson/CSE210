public class Checklist : Goals
{
    private int _bonusPoints;
    private int _steps;
    private int _stepsCompleted;
    
    public Checklist(string name, string description, int Goalpoints, int bonusPoints, int steps) 
        : base(name, description, Goalpoints)
    {
        _bonusPoints = bonusPoints;
        _steps = steps;
        _stepsCompleted = 0;
    }

    public override string Getgoal()
    {
        string baseGoal = base.Getgoal();
        return baseGoal;
    }

    public override void AddPoints()
    {
        if (_stepsCompleted >= _steps)
        {
            base.AddPoints(_bonusPoints);
        }
        else
        {
            base.AddPoints();
        }
    }

    public override void RecordEvent()
    {
        _stepsCompleted++;
        
        // Check if we've reached the target
        if (_stepsCompleted >= _steps)
        {
            base.RecordEvent();
        }
        
        AddPoints();
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public int GetStepsCompleted()
    {
        return _stepsCompleted;
    }

    public int GetSteps()
    {
        return _steps;
    }

    public void StepsCompleted(int steps)
    {
        _stepsCompleted = steps;
    }
}
