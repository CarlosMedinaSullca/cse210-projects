using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the PromptGenerator Class
        PromptGenerator prompList1 = new PromptGenerator();
        // Assigning a list to the _prompts attribute from PromptGenerator Class
        prompList1._prompts = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"];        

        // Creating an instance of the Journal Class
        Journal j1 = new Journal();
        j1._entries = new List<Entry>();        

        Console.WriteLine("Welcome to the Journal Program!");
        
        int userChoice = 0;

        while (userChoice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            userChoice = int.Parse(userInput);
                    
            if (userChoice == 1)
            {
                Console.Write("Would you like to get a prompt?");
                string writeMode = Console.ReadLine().ToLower();
                if (writeMode == "yes")
                {
                    // Creating an instance of the DateTime Class
                    DateTime theCurrentTime = DateTime.Now;
                    // Creating an instance of the Entry Class
                    Entry entry1 = new Entry();
                    entry1._date = theCurrentTime.    ToShortDateString();
                    //Calling the GetRandomPrompt method to     get a random prompt, assigning it to the     _prompText attribute of the Entry class     and then priting the random prompt
                    entry1._prompText = prompList1.    GetRandomPrompt();
                    Console.WriteLine(entry1._prompText);
                    // Getting the user response input and     storing in the _entryText attribute from     the Entry class
                    entry1._entryText = Console.ReadLine();

                    // Adding the Entry to the list of entries     of the Journal class
                    j1.AddEntry(entry1);

                }
                else
                {
                    // Creating an instance of the DateTime Class
                    DateTime theCurrentTime = DateTime.Now;
                    // Creating an instance of the Entry Class
                    Entry entry2 = new Entry();
                    entry2._date = theCurrentTime.    ToShortDateString();
                                        
                    // Getting the user response input and     storing in the _entryText attribute from     the Entry class
                    entry2._entryText = Console.ReadLine();

                    // Adding the Entry to the list of entries     of the Journal class
                    j1.AddEntry(entry2);
                }              
                            
            }

            else if (userChoice ==2)
            {
                j1.DisplayAll();
            }

            else if (userChoice == 4)
            {
                j1.SaveToFile("journal.txt");
            }
            else if(userChoice == 3)
            {
                j1.LoadFromFile("journal.txt");
            }

        }
    }
}