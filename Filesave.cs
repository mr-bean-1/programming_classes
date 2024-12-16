using System;
using System.Collections.Generic;
using System.IO;
// I used AI for this feature - I couldn't figure it out on my own and used it for an example

public class Filesave
{
    public void SaveGoalsToFile(string filename, List<Goal> goals)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.SaveGoalInfo());
            }
        }
    }

    public List<Goal> LoadGoalsFromFile(string filename)
    {
        List<Goal> goals = new List<Goal>();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string goalType = parts[0];

                    if (goalType == "Simple")
                    {
                        string name = parts[1].Trim();
                        string description = parts[2].Trim();
                        int points = int.Parse(parts[3].Trim());
                        goals.Add(new Simple(name, description, points));
                    }
                    else if (goalType == "Eternal")
                    {
                        string name = parts[1].Trim();
                        string description = parts[2].Trim();
                        int points = int.Parse(parts[3].Trim());
                        goals.Add(new Eternal(name, description, points));
                    }
                    else if (goalType == "Checklist")
                    {
                        string name = parts[1].Trim();
                        string description = parts[2].Trim();
                        int points = int.Parse(parts[3].Trim());
                        int completions = int.Parse(parts[4].Trim());
                        int timesToComplete = int.Parse(parts[5].Trim());
                        int bonusPoints = int.Parse(parts[6].Trim());
                        goals.Add(new Checklist(name, description, points, timesToComplete, bonusPoints));
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }

        return goals;
    }
}
