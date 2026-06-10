namespace TypingApp.Shared;

public class TypingPrompt
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
}

public class TypingStats
{
    public double WPM { get; set; }
    public double Accuracy { get; set; }
    public int ElapsedSeconds { get; set; }
    public int Mistakes { get; set; }
}
