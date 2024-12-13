// I ADDED CODE TO KEEP A LOG OF HOW MANY TIMES ACTIVITIES WERE PERFORMED. WHEN THE USER CHOOSES "QUIT"  THE PROGRAMM SHOWS THE TIMES THE USER WENT THROUGH EVERY ACTIVITY.

using System;

class Program
{
    static void Main(string[] args)
    {
        int breathing = 0;
        int reflection = 0;
        int listing = 0;
        int userSelection = 0;
        while(userSelection != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the Menu: ");
            userSelection = int.Parse(Console.ReadLine());

            if (userSelection == 1) {

                //RUNNING BREATHING ACTIVITY
                string breathDescri = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and         focus on your breathing.";
                BreathingActivity a = new BreathingActivity("Breathing activity", breathDescri);

                a.DisplayStartingMessage();
                a.Run();
                a.DisplayEndingMessage();  
                breathing ++;
            }
            else if (userSelection == 2) {
                //RUNNING REFLECTING ACTIVITY        
                List<string> rePrompt = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };

                List<string> question = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
                string reDescri = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

                ReflectingActivity r1 = new ReflectingActivity("Reflecting Activity", reDescri, rePrompt, question);
        
                r1.DisplayStartingMessage();
                r1.Run();
                r1.DisplayEndingMessage();
                reflection ++;
            }

            else if (userSelection == 3) 
            {
                //RUNNING LISTING ACTIVITY   
                List<string> liPrompt = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
                string liDescri = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity l1 = new ListingActivity("Listing Activity", liDescri, liPrompt);                
                l1.DisplayStartingMessage();
                l1.Run();
                l1.DisplayEndingMessage();

                listing ++;
            }

            else
            {
                if (userSelection != 4)
                {
                    Console.WriteLine("Wrong Input");
                }
                
            }
        }

        if ( breathing != 0)
        {
            if (breathing == 1)
            {
                Console.WriteLine($"You have went through breathing activity {breathing} time.");

            }
            else
            {
                Console.WriteLine($"You have went through breathing activity {breathing} times.");

            }
            
        }

        if ( reflection != 0)
        {
            if (reflection == 1)
            {
                Console.WriteLine($"You have went through breathing activity {reflection} time.");

            }
            else
            {
                Console.WriteLine($"You have went through breathing activity {reflection} times.");

            }
            
        }

        if ( listing != 0)
        {
            if (listing == 1)
            {
                Console.WriteLine($"You have went through breathing activity {listing} time.");

            }
            else
            {
                Console.WriteLine($"You have went through breathing activity {listing} times.");

            }
            
        }
    }
}