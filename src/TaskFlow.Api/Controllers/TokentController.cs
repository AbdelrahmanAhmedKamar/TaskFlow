using Microsoft.AspNetCore.Mvc;
using TaskFlow.Api.Identity;
using TaskFlow.Api.Requests;

namespace TaskFlow.Api.Controllers;

[ApiController]
[Route("api/token")]
public class TokenController(JwtTokenProvider tokenProvider) : ControllerBase
{

    [HttpPost("generate")]
    public IActionResult GenerateToken(GenerateTokenRequest request)
    {
        return Ok(tokenProvider.GenerateJwtToken(request));
    }
}