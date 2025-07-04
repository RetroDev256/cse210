public class HighScores
{
    private List<Score> _scores;

    public HighScores()
    {
        _scores = new List<Score>();

        // The prefixed dot is a standard UNIX way of saying
        // that a file is intended to be hidden - not the same
        // as saying a "hidden file" in windows, though.
        if (File.Exists(".scores"))
            foreach (string line in File.ReadLines(".scores"))
                _scores.Add(new Score(line));
    }

    public void Save()
    {
        // The "append: false" means to overwrite the file if it exists.
        StreamWriter writer = new StreamWriter(".scores", append: false);

        foreach (Score s in _scores)
            writer.WriteLine(s.Serialize());

        writer.Close();
    }

    // Adds a score to the list of high scores, making sure that it
    // is large enough to be considered a "high score" (top 10) before
    // it asks for the user's name (and gets the date from the system).
    public void AddScore(int value)
    {
        // Early exit if the score won't be added
        if (_scores.Count == 10)
            if (_scores[9].GetValue() >= value)
                return;

        // Get the other data we need to make a Score
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Console.WriteLine("Congratulations - you are on the scoreboard!");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Place this value in the list of scores, sort in descending order
        _scores.Add(new Score(value, date, name));
        _scores.Sort(CompareScores);

        // Remove scores if we have more than 10 - we never use more anyways
        if (_scores.Count > 10)
            _scores.RemoveRange(10, _scores.Count - 10);
    }

    // This function assumes that there is at least one score, but because
    // we always attempt to add a score to the scoreboard before we render
    // the high scores, we can safely assume that there is at least one. 
    public string Format()
    {
        string scoreboard = "#:   Points:   Date:        Name:\n";
        for (int i = 0; i < _scores.Count; i += 1)
            scoreboard += $"{i + 1,2} - {_scores[i].Format()}\n";
        return scoreboard;
    }

    // Required by C#'s STDLIB for sorting lists of Score
    private static int CompareScores(Score a, Score b)
    {
        return b.GetValue().CompareTo(a.GetValue());
    }
}