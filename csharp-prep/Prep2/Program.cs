using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        int remainder = grade % 10;

        string sign = " ";
        
        string letter = " "; 

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (remainder >= 7 && grade < 97 && grade > 60) 
        {
            sign = "+";
        }
        else if (remainder < 3 && grade < 97 && grade > 60)
        {
            sign = "-";
        }
        else
        {
            sign = " ";
        }

        Console.WriteLine($"Your letter grade is {sign}{letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Explore ways to improve and try againg the next semester!");
        }




    }
}