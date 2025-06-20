namespace Logging.Shared.Models;

public class LogEntry
{
    public string AppName { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string? Exception { get; set; }
    public string Level { get; set; } = "Information";
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    public Dictionary<string, string>? Tags { get; set; }
}
