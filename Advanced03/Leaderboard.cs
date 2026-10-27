namespace Advanced03;

public static class Leaderboard
{
    public static void Run()
    {
        SortedList<int, string> scores = new();
        scores.Add(500, "Ahmed");
        scores.Add(200, "Sara");
        scores.Add(800, "Ali");
        scores.Add(350, "Mona");

        #region Print all entries 
        foreach (var score in scores)
        {
            Console.WriteLine($"Score: {score.Key} - Player: {score.Value}");
        }
        #endregion

        #region Access the first key and first value 
        Console.WriteLine(scores.Keys[0]);
        Console.WriteLine(scores.Values[0]);
        #endregion

        #region Check if score 500 exists
        Console.WriteLine(scores.ContainsKey(500));
        #endregion

        #region get the player with score 999
        if (scores.TryGetValue(999, out string? value))
        {
            Console.WriteLine(value);
        }
        else
        {
            Console.WriteLine("There is no player with score 999");
        }
        #endregion

        #region Remove the player with score 200
        scores.Remove(200);
        Console.WriteLine("\nScores After Removing Player With Score 200:");
        foreach (var score in scores)
        {
            Console.WriteLine(score);
        }
        #endregion
    }

}
