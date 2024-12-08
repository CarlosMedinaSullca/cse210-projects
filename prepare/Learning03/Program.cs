using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        f1.SetTop(4);
        f1.SetBottom(5);
        Fraction f2 = new Fraction(6);
        f2.SetTop(4);
        f2.SetBottom(5);
        Fraction f3 = new Fraction(2, 3);
        f3.SetTop(4);
        f3.SetBottom(5);
        Fraction f4 = new Fraction(1, 4);

        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetBottom());

        

    }
}