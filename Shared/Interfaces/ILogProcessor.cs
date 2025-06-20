using Logging.Shared.Models;

namespace Logging.Shared.Interfaces;

public interface ILogProcessor
{
    Task ProcessAsync(LogEntry entry, CancellationToken cancellationToken = default);
}
