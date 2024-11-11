using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int userNumber = 1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            numbers.Add(userNumber);
        }

        float sumOfNumbers = 0;
        float totalNumbers = -1;
        int maxNumber = -1;
        int diference = 100000;
        int smallestPositiveNumber = 1000;

        foreach ( int number in numbers)
        {
            sumOfNumbers += number;
            totalNumbers += 1;
            if (number > maxNumber)
            {
                maxNumber = number;
            }
            
            if (number > 0)
            {
                int movilDiference = number - 0;
                if (movilDiference < diference)
                {
                    diference = movilDiference;
                    smallestPositiveNumber = number;
                }
            }

        }

        
        Console.WriteLine($"The sum is: {sumOfNumbers}");
        float average = sumOfNumbers / totalNumbers;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine("The sorted list is:");
        numbers.Sort();

        foreach (int a in numbers)
        {
            if (a != 0)
            {
                Console.WriteLine(a);
            }
        }

    }
}