public class Job
{
    public string _company;
    public int _startYear;
    public int _endYear;
    public string _jobTitle;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}