namespace ML_WPF.Models;

public class ReviewEntry
{
    public string Text { get; set; } = string.Empty;
    public bool IsPositive { get; set; }
    public DateTime Timestamp { get; set; }
}
