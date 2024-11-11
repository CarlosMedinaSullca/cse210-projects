using System;

class Program
{
    static void Main(string[] args)
    {
        string Welcome = DisplayWelcome();
        Console.WriteLine($"{Welcome}");
        string name =PromptUserName();
        int number = PromptUserNumber();
        int numberSquare = SquareNumber(number);
        Console.WriteLine($"{name}, the square of your number is {numberSquare}");
    }

    static string DisplayWelcome()
    {
        string welcome = "Welcome to the program";
        return welcome;
    }

        static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        string userNumber = Console.ReadLine();
        int favoriteUserNumber = int.Parse(userNumber);
        // int squareNumber = favoriteUserNumber * favoriteUserNumber
        return favoriteUserNumber;
    }

    static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;

    }
}