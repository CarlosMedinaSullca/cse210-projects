using System;
// EXCCEDING REQUIREMENTS. I ALLOW THE USER TO ENTER THE CHAPTER, BOOK, VERSES AND TEXT THAT SHE WANTS TO MEMORIZE

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("If you want to enter your own scripture enter the number 1. If you want to try a default scritpure enter the number 2: ");
        int optionNumber = int.Parse(Console.ReadLine());

        if (optionNumber == 1) {
            Console.Write("Enter the name of the book");
            string book = Console.ReadLine();
            Console.Write("Enter the chapter of the book: ");
            int chapter = int.Parse(Console.ReadLine());
            Console.Write("Enter the first verse: ");
            int verse1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the last verse or just enter the number 0: ");
            int verse2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the verse or verses");
            string verses = Console.ReadLine();
        
            Console.Clear();
        

        // string script1= "Perezca el día en que yo nací y la noche en que se dijo: Un varón ha sido concebido. Sea aquel día sombrío, y no cuide de él Dios desde arriba ni claridad sobre él resplandezca.";
            Reference r1 = new Reference(book, chapter, verse1);
            Reference r2 = new Reference(book, chapter, verse1, verse2);
            Scripture s1 = new Scripture( r1, verses);
            Scripture s2 = new Scripture( r2, verses);

            if (verse2 == 0) {
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

            else {
                Console.WriteLine(s2.GetDisplayText());

                string continueMemorizer = ""; 

                while (s2.IsCompletelyHidden() != true ) {
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

        else {
            
            string book = "Job";
            int chapter = 3;   
            int verse1 = 3;
            Reference r1 = new Reference(book, chapter, verse1);
            string verses = "Perezca el día en que yo nací y la noche en que se dijo: Un varón ha sido concebido. Sea aquel día sombrío, y no cuide de él Dios desde arriba ni claridad sobre él resplandezca.";
            Scripture s1 = new Scripture( r1, verses);

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
}