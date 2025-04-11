public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
        }
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetStatus()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} Completed {_currentCount}/{_targetCount} times --";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_targetCount},{_bonus},{_currentCount}";
    }

    public int GetCurrentCount() => _currentCount;
    public int GetTargetCount() => _targetCount;
    public int GetBonus() => _bonus;
}
