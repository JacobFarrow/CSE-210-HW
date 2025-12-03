class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int  _bonus;
    public ChecklistGoal(string shortname, string description, int points, int target, int bonus) : base(shortname, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override int RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} | Completed {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal | {_shortname} | {_description} | {_points} | {_bonus} | {_target} | {_amountCompleted}";
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
}