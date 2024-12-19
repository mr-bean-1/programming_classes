
public class SaveGoal
{
    private List<Goal> goals;

    public SaveGoal()
    {
        goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public int GetTotalPoints()
    {
        int totalPoints = 0;
        foreach (var goal in goals)
        {
            totalPoints += goal.Points;
        }
        return totalPoints;
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            goal.DisplayGoalInfo();
        }
    }

    public List<Goal> GetGoals()
    {
        return goals;
    }
}