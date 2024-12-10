using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Video v1 = new Video();
        v1._title = "A beautiful day";
        v1._author = "Pablo Perez";
        v1._length = 300;
        Comment c1 = new Comment();
        c1._name= "Pedro";
        c1._text = "Amazing video, more videos please.";
        Comment c2 = new Comment();
        c2._name= "Mateo";
        c2._text = "Great, I liked graphics";
        Comment c3 = new Comment();
        c3._name= "Juan";
        c3._text = "Kind of large...";
        v1._comments = [c1, c2, c3];

        Video v2 = new Video();
        v2._title = "A delicious cheap recipe";
        v2._author = "Marcelo Iturralde";
        v2._length = 520;
        Comment c4 = new Comment();
        c4._name= "Pedro";
        c4._text = "Amazing video, more videos please.";
        Comment c5 = new Comment();
        c5._name= "Mateo";
        c5._text = "Great, I liked graphics";
        Comment c6 = new Comment();
        c6._name= "Juan";
        c6._text = "Kind of large...";
        v2._comments = [c4, c5, c6];

        Video v3 = new Video();
        v3._title = "Unforgetable journey";
        v3._author = "Joel Martinez";
        v3._length = 360;
        Comment c7 = new Comment();
        c7._name= "Pedro";
        c7._text = "Amazing video, more videos please.";
        Comment c8 = new Comment();
        c8._name= "Mateo";
        c8._text = "Great, I liked graphics";
        Comment c9 = new Comment();
        c9._name= "Juan";
        c9._text = "Kind of large...";
        v3._comments = [c7, c8, c9];

        List<Video> Videos = new List<Video>();

        Videos = [v1, v2, v3,];

        foreach (Video v in Videos) {
            Console.WriteLine(v.DisplayVideoInfo());

            Console.WriteLine("Comments:");            
            foreach (Comment c in v._comments) {
                Console.WriteLine(c.DisplayCommenterAndText());
            }
            Console.WriteLine("");
        }

    }
}