using Microsoft.AspNetCore.Components;

namespace TeamR.Api.Controllers.V1;

[Route("/[controller]")]
public class UserController(ILogger<UserController> logger) : V1Controller(logger)
{
    
}