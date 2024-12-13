public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
    }
    public ListingActivity(int duration) : base(duration)
    {
        
    }    
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(1);
        Console.WriteLine("List as many responses you can to the following prompt:");
        DisplayPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(1);
        Console.WriteLine("");
        List<string> userList= new List<string>();
        userList = GetListFromUser();
        foreach (string s in userList)
        {
            _count ++;
        }
        Console.WriteLine($"You listed {_count} items!");        
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

    public List<string> GetListFromUser()
    {
        List<string> listFromUser = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string userWriting = Console.ReadLine();
            listFromUser.Add(userWriting);                  
        } 

        return listFromUser;        
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }


}