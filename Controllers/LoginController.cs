using Microsoft.AspNetCore.Mvc;

namespace chat_backend.Controllers;

[ApiController]
[Route("[controller]")]

public class LoginController: ControllerBase {

    [HttpPost(Name = "Logar")]

    public bool Post(LoginDTO login) {
        return true;
    }
}