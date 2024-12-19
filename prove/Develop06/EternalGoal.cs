public class EternalGoal : Goal 
{

    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public EternalGoal()
    {        

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {     
        return true;   
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}