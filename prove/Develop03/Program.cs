using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Job", 3, 3);
        Reference r2 = new Reference("Job", 3, 3, 4);

        // TESTING THE REFERENCEC CLASS
        // Console.WriteLine(r1.GetDisplayText());
        // Console.WriteLine(r2.GetDisplayText());
        
        //TESTING WORD CLASS
        // Word w1 = new Word("Carlos");
        // // Console.WriteLine(w1.GetDisplayText());
        // w1.Hide();
        // Console.WriteLine(w1.GetDisplayText());
        // w1.Show(); 
        // Console.WriteLine(w1.GetDisplayText());    


        string script1= "Perezca el día en que yo nací y la noche en que se dijo: Un varón ha sido concebido. Sea aquel día sombrío, y no cuide de él Dios desde arriba ni claridad sobre él resplandezca.";

        Scripture s1 = new Scripture( r2, script1);
        
        Console.WriteLine(s1.GetDisplayText());

        string continueMemorizer = ""; 

        while (s1.IsCompletelyHidden() != true ) {
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            continueMemorizer = Console.ReadLine();
            if (continueMemorizer == "quit"){
                break;
            }
            else {
                Console.Clear();
                s1.HideRandomWords(3);
                Console.WriteLine(s1.GetDisplayText());
            }
            
        }    
    }
}