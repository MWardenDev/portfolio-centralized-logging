using Logging.Shared.Models;
using Logging.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Logging.API.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class LogsController : ControllerBase
{
    private readonly ILogProcessor _processor;

    public LogsController(ILogProcessor processor)
    {
        _processor = processor;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] LogEntry entry)
    {
        await _processor.ProcessAsync(entry);
        return Ok();
    }
}
