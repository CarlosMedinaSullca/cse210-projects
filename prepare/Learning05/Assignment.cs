public class Assignment 
{
    protected string _studentName;
    private string _topic;

    public Assignment(string studentname, string topic) {
        _studentName = studentname;
        _topic = topic;
    }

    public string GetStudentName() {
        return _studentName;
    }
    public void SetStudentName(string studentname) {
        _studentName = studentname;
    }

    public string GetSummary() {
        return $"{_studentName} - {_topic}";
    }

}