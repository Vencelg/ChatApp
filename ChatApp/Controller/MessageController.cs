using ChatApp.Definition.Request;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controller;

[Route("api/message")]
[ApiController]
public class MessageController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMessages()
    {
        return Ok();
    }

    [HttpGet("/{id:guid}")]
    public IActionResult GetMessage(Guid id)
    {
        return Ok(id);
    }

    [HttpPost]
    public IActionResult CreateMessage(CreateMessageRequest request)
    {
        return Ok(request);
    }

    [HttpPut("/{id:guid}")]
    public IActionResult UpdateMessage(Guid id, UpdateMessageRequest request)
    {
        return Ok(id);
    }

    [HttpDelete("/{id:guid}")]
    public IActionResult DeleteMessage(Guid id)
    {
        return Ok(id);
    }
}