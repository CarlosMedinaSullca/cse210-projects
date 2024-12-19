public abstract class Goal {
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal()
    {
        _shortName = "";
        _description= "";
        _points = "";
    }

    public void setName(string name)
    {
        _shortName = name;
    }
    public string getName()
    {
        return _shortName;
    }
    public void setDescription(string description)
    {
        _description = description;
    }
    public void setPoints(string points)
    {
        _points = points;
    }

    public string GetPoints()
    {
        return _points;
    }

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual string GetDetailsString()
    {
        string details= "";
        if (IsComplete() == true)
        {
            details= $"[X] {_shortName} ({_description})";
            
        }
        else
        {
            details =$"[ ] {_shortName} ({_description})";
            
        }
        
        return details;
    }

    public virtual string GetStringRepresentation()
    {
        return "Great";
    }
}