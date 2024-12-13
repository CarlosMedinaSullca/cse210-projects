using System.Runtime.InteropServices.Marshalling;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public Activity (int duration)
    {
        _duration = duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session?: ");
        int actTime = int.Parse(Console.ReadLine());
        SetDuration(actTime);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Console.ReadLine();
    

    }

    public void ShowSpinner(int second)
    {
        int milisec = second * 1000;
        List<String> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(milisec);
            Console.Write("\b \b");   
            i++;

            if (i >= animationStrings.Count)
            {
                i= 0;
            }         
        }

    }

    public void ShowCountDown(int second)
    {
        int milisec = second * 1000;
        // This loop shows a count down timer from 5 to 0. Each step will last the numbers of second assignment.
        // The method sleep receives the parameter in miliseconds. One second is 1000 miliseconds.
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(milisec);
            // This line of code bellow erase the previous number to show the next.
            Console.Write("\b \b");
        }
        
    }


}