using Microsoft.AspNetCore.Mvc;
using TimeTravelAgency.Services;

namespace TimeTravelAgency.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChatController : ControllerBase
{
    private readonly MistralService _mistral;

    public ChatController(MistralService mistral)
    {
        _mistral = mistral;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ChatRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Message))
            return BadRequest();

        var reply = await _mistral.AskAsync(request.Message);

        return Ok(new { reply });
    }
}

public class ChatRequest
{
    public string Message { get; set; } = "";
}
