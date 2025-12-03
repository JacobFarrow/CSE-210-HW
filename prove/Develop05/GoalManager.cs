using System.Security.Cryptography.X509Certificates;
using System.IO;
class GoalManager
{
    protected int _score;
    protected List<Goal> _goals = new List<Goal>();
    public GoalManager()
    {
        _score = 0;
    }
    public int DisplayPlayerInfo()
    {
        return _score;
    }
    public void ListGoalNames()
    {
        int _count;
        _count = 0;
        foreach (Goal goal in _goals)
        {
            _count += 1;
            Console.WriteLine($"{_count}. {goal.GetName()}");
        }
    }
    public void ListGoalDetails()
    {
        int _counter;
        _counter = 0;
        foreach (Goal goal in _goals)
        {
            _counter += 1;
            Console.WriteLine($"{_counter} | {goal.GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine(@$"What kind of goal would you like?
1. Simple Goal
2. Eternal Goal
3. Checklist Goal
");
        string choice = Console.ReadLine();
        Console.WriteLine("What is the name of your goal?");
        string shortname = Console.ReadLine();
        Console.WriteLine("Describe your goal:");
        string description = Console.ReadLine();
        Console.WriteLine("How many point is this goal worth (0-100)?");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            SimpleGoal newGoal = new SimpleGoal(shortname, description, points);
            _goals.Add(newGoal);
        }
        else if (choice == "2")
        {
           EternalGoal newGoal = new EternalGoal(shortname, description, points);
           _goals.Add(newGoal); 
        }
        else if (choice == "3")
        {
            Console.WriteLine("What is your quantity target?");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("How many points is this worth for fully completing?");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal newGoal = new ChecklistGoal(shortname, description, points, target, bonus);
            _goals.Add(newGoal);
        }
    }
    public int RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish?");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        Goal currentGoal = _goals[goalIndex];
        int points = currentGoal.RecordEvent();
        _score += points;
        Console.WriteLine(@$"You have gained {points} points for a total of {_score} points.");
        return _score;
    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
           outputFile.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        } 
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            _score = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                string goalType = parts[0].Trim();
                string name = parts[1].Trim();
                string description = parts[2].Trim();
                int points = int.Parse(parts[3].Trim());

                if (goalType == "Simple Goal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    SimpleGoal newGoal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        newGoal.RecordEvent();
                    }
                    _goals.Add(newGoal);
                }
                else if (goalType == "Eternal Goal")
                {
                    EternalGoal newGoal = new EternalGoal(name, description, points);
                    _goals.Add(newGoal);
                }
                else if (goalType == "Checklist Goal")
                {
                    int bonus = int.Parse(parts[4].Trim());
                    int target = int.Parse(parts[5].Trim());
                    int amount = int.Parse(parts[6].Trim());

                    ChecklistGoal newGoal = new ChecklistGoal(name, description, points, target, bonus);
                    newGoal.SetAmountCompleted(amount);
                    _goals.Add(newGoal);
                }
            }
        }
    }
}