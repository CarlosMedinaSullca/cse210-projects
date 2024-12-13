public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, List<String> prompts, List<String> questions) : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public ReflectingActivity(int duration) : base(duration)
    {}


    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(1);
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("You may begin in: ");
        ShowCountDown(1);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(1);       
        }    
        
    }

    public string GetRandomPrompt()
    {
        // Random object
        Random rnd = new Random();

        // Get random index
        int index = rnd.Next(_prompts.Count);

        // Assingning a variable to the random prompt
        string randomPrompt = _prompts[index];

        // Return random prompt
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        // Random object
        Random rnd = new Random();

        // Get random index
        int index = rnd.Next(_questions.Count);

        // Assingning a variable to the random prompt
        string randomPrompt = _questions[index];

        // Return random prompt
        return randomPrompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($">{GetRandomQuestion()}");
    }
}