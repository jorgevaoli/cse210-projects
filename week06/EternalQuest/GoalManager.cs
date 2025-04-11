using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        Goal goal = _goals[index];
        goal.RecordEvent();

        _score += goal.GetPoints();

        if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete() &&
            checklistGoal.GetCurrentCount() == checklistGoal.GetTargetCount())
        {
            _score += checklistGoal.GetBonus();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetStatus()} {goal.GetName()} ({goal.GetDescription()})");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string[] details = parts[1].Split(",");

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(details[0], details[1], int.Parse(details[2]));
                if (bool.Parse(details[3])) g.RecordEvent();
                _goals.Add(g);
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal g = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4]));
                while (g.GetCurrentCount() < int.Parse(details[5])) g.RecordEvent();
                _goals.Add(g);
            }
        }
    }
}
