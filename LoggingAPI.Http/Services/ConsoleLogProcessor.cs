using Logging.Shared.Models;
using Logging.Shared.Interfaces;


namespace Logging.API.Http.Services;

public class ConsoleLogProcessor : ILogProcessor
{
    public Task ProcessAsync(LogEntry entry, CancellationToken cancellationToken = default)
    {
        Console.WriteLine($"[{entry.Timestamp}] {entry.Level}: {entry.Message}");
        return Task.CompletedTask;
    }
}
