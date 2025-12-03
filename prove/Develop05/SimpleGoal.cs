class SimpleGoal : Goal
{
    protected bool _isComplete;
    public SimpleGoal(string shortname, string description, int points) : base(shortname, description, points)
    {
        _isComplete = false;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"Simple Goal | {_shortname} | {_description} | {_points} | {_isComplete}";
    }
}