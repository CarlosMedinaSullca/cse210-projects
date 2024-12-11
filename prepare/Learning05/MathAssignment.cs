public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentname, string topic, string textbooksection, string problems) : base(studentname, topic)
    {
        _textbookSection = textbooksection;
        _problems = problems;
    }

    public string GetHomeworkList() {
        return $"{_textbookSection} - {_problems}";
    }

}