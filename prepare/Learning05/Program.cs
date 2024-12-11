using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Juan", "Anatomy");
        Console.WriteLine(a1.GetSummary());

        MathAssignment m1 = new MathAssignment("Mateo", "Atomic theory","Section 3.2", "Problems 3 -20");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Roberta", "America discovery", "Native People abuse");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());




    }
}