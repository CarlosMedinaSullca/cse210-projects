public class Reference
{
    // This class keeps track of the book, chapter, and verse information.
    //Atributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        
    }

    //Behavior

    public string GetDisplayText()
    {
        // It should have the ability to get the display text of the reference, which is just a string combining the book, chapter, and verse (or verses).
        if (_endVerse != 0 )
        {
            // Console.WriteLine($"{_book} {_chapter}: {_verse}-{_endVerse}");
            return $"{_book} {_chapter}: {_verse}-{_endVerse}";
        }
        else
        {
            // Console.WriteLine($"{_book} {_chapter}: {_verse}");
            return $"{_book} {_chapter}: {_verse}";
        }
    }
}