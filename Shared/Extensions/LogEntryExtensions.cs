using Logging.Shared.Models;

namespace Logging.Shared.Extensions;

public static class LogEntryExtensions
{
    public static LogEntry WithTraceContext(this LogEntry entry, string traceId, string spanId)
    {
        entry.Tags ??= new Dictionary<string, string>();
        entry.Tags["trace_id"] = traceId;
        entry.Tags["span_id"] = spanId;
        return entry;
    }
}
