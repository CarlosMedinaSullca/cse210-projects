public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    protected int _bonus;

    public ChecklistGoal(string name, string description, string points, int bonus, int target, int completed) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = completed;
    }

    public ChecklistGoal()
    {

    }
    public void setAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public int getAmountCompleted()
    {
        return _amountCompleted;
    }

    public void setTarget(int target)
    {
        _target = target;
    }

    public int getTarget()
    {
        return _target;
    }
    public void setBonus(int bonus)
    {
        _bonus = bonus;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted ++;

        if (_target != _amountCompleted)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }

        else if (_target == _amountCompleted)
        {
            int points = _bonus + int.Parse(_points);
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }        
    }

    public override bool IsComplete()
    {
        bool completed = true;
        return completed;    
    }

    public override string GetDetailsString()
    {
        string detailString = "";
        if (_amountCompleted != _target)
        {
            detailString = $"[] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }
        else if (_amountCompleted == _target)
        {
            detailString = $"[X] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }

        return detailString;
                
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}