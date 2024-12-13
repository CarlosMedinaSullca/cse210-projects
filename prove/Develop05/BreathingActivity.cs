public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {}

    public BreathingActivity(int duration) : base(duration)
    {}

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(1);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);                
                Console.Write("\b \b");
                if (i == 1)
                {Console.WriteLine("");}
            }

            Console.Write("Now breathe out...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);                
                Console.Write("\b \b");
                if (i == 1)
                {Console.WriteLine("");}
            }
            Console.WriteLine(""); 

        }        
    }
}