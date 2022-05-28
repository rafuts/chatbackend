using chatbackend.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace chat_backend.Controllers;

[ApiController]
[Route("[controller]")]

public class LoginController : ControllerBase
{
    private readonly ILoginService _service;
    public LoginController(ILoginService service)
    {
        _service = service;
    }
    [HttpPost(Name = "Logar")]

    public bool Post(LoginDTO login)
    {
        var resultado = _service.Logar(login);
        return resultado;
    }
}