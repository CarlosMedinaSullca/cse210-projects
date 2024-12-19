public class GoalManager 
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;

    }
    

    public void Start()
    {
        int userSelection = 0;
        
        while (userSelection != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu:");
            userSelection = int.Parse(Console.ReadLine());

            if (userSelection == 1)
            {
                CreateGoal();
            }
            else if (userSelection == 2)
            {
                ListGoalDetails();
            }
            else if (userSelection == 3)
            {
                SaveGoals();
            }
            else if (userSelection == 4)
            {
                LoadGoals();
            }
            else if (userSelection == 5)
            {
                RecordEvent();
            }
            else
            {
                if (userSelection != 6)
                {
                    Console.WriteLine("Bad input");
                } 
            }
        }
        
                        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int i = 0;
        foreach (Goal g in _goals)
        {
            i = i + 1;
            Console.WriteLine($"{i}. {g.getName()}");
        }
        
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        int i = 0;
        foreach (Goal g in _goals)
        {
            i = i + 1;
            Console.WriteLine($"{i}. {g.GetDetailsString()}");
        }        
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?" );
        string userGoal = Console.ReadLine();

        if (userGoal == "1")
        {
            SimpleGoal s = new SimpleGoal();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            s.setName(name);
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            s.setDescription(description);
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            s.setPoints(points);
            _goals.Add(s);
        }
        else if (userGoal == "2")
        {
            EternalGoal e = new EternalGoal();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            e.setName(name);
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            e.setDescription(description);
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            e.setPoints(points);
            _goals.Add(e);

        }
        else if (userGoal == "3")
        {
            ChecklistGoal c = new ChecklistGoal();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            c.setName(name);
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            c.setDescription(description);
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            c.setPoints(points);
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            c.setTarget(target);
            Console.Write("What is the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());
            c.setBonus(bonus);
            _goals.Add(c);
        }
        else 
        {
            Console.WriteLine("Bad input");
        }

    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish?");
        int userInput = int.Parse(Console.ReadLine());
        int index = userInput - 1;
        _goals[index].RecordEvent();
        if (_goals[index].IsComplete() == true)
        {
            _score += int.Parse(_goals[index].GetPoints());
        }

    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter (fileName))
        {
            // Adding text to the file with the WriteLine method
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }    
        }

    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string typeOfObject = parts[0];
            string details = parts[1];
            string[] goalParts = details.Split(",");
            // Creating goal objects depending on the kink of goal in saved in the file.
            if (typeOfObject == "SimpleGoal")
            {
                SimpleGoal s = new SimpleGoal(goalParts[0], goalParts[1], goalParts[2]);
                _goals.Add(s);
            }
            else if (typeOfObject == "EternalGoal")
            {
                EternalGoal e = new EternalGoal(goalParts[0], goalParts[1], goalParts[2]);
                _goals.Add(e);
            }
            else if (typeOfObject == "ChecklistGoal")
            {
                ChecklistGoal c = new ChecklistGoal(goalParts[0], goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]), int.Parse(goalParts[5]) );
                _goals.Add(c);
            }
        }

    }
}