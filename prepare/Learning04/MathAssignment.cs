public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBookSelection, string problems) : base(studentName, topic)
    {
        _textbookSection = textBookSelection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} - Problems: {_problems}";
    }
}