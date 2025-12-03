class EternalGoal : Goal
{
    public EternalGoal(string shortname, string description, int points) : base(shortname, description, points)
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override int RecordEvent()
    {
        return _points;
    }
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal | {_shortname} | {_description} | {_points}";
    }
}