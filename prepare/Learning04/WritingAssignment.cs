public class WritingAssignment : Assignment
{
    private string _paperTitle;
    public WritingAssignment(string studentName, string topic, string paperTitle) : base(studentName, topic)
    {
        _paperTitle = paperTitle;
    }
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"Title of paper: {_paperTitle} By {studentName}";
    }
}