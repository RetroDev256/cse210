using System;

class Program
{
    static void Main(string[] args)
    {   
        // Initialization
        Coordinate dim = new Coordinate(80, 25);
        Game game = new Game(dim);
        HighScores scores = new HighScores();

        // Splash Screen
        Console.WriteLine("Welcome to Snake!");
        Console.WriteLine();
        Console.WriteLine("Instructions:");
        Console.WriteLine("- Use the arrow keys to move around.");
        Console.WriteLine("- Consume food to earn points.");
        Console.WriteLine("- Avoid the wall and your tail.");
        Console.WriteLine();
        Console.Write("Press any key to begin... ");
        _ = Console.ReadKey();

        // Gameplay
        int score = game.Run();
        scores.AddScore(score);
        scores.Save();
        
        // Scoreboard display
        string scoreboard = scores.Format();
        Console.WriteLine($"\n{scoreboard}");
    }
}