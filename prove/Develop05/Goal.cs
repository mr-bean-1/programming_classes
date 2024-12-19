

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

// Base Goal Class
public abstract class Goal
{
    private string name;
    private string description;
    private int points;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
    }

    public string Name => Name; 
    public string Description => description;
    public int Points => points; 

    public abstract void DisplayGoalInfo();
    public abstract string SaveGoalInfo();
}

