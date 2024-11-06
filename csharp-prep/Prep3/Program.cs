using System;

class Program
{
    static void Main(string[] args)
    {
        string continuePlaying = "yes";
        while (continuePlaying == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int numberOfAttempts = 0;
            int guess = 0;
            while ( guess != magicNumber)
            {
                Console.Write("What is the magic number? ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higuer");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                numberOfAttempts += 1;
            }

            Console.WriteLine($"You have made {numberOfAttempts} guesses.");

            Console.Write("Do you want to continue playing? ");
            string userWill= Console.ReadLine();
            continuePlaying = userWill.ToLower();
        }
    }
}