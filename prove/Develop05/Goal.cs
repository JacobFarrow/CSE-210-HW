abstract class Goal
{
    protected string _shortname;
    protected string _description;
    protected int _points;

    public Goal(string shortname, string description, int points)
    {
        _shortname = shortname;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] - {_shortname} - {_description}";
        }
        else
        {
            return $"[] - {_shortname} - {_description}";
        }
    }
    public abstract string GetStringRepresentation();
    public string GetName()
    {
        return _shortname;
    }
}