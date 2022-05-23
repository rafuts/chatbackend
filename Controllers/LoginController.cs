using Microsoft.AspNetCore.Mvc;
using Npgsql;
namespace chat_backend.Controllers;

[ApiController]
[Route("[controller]")]

public class LoginController: ControllerBase {

    [HttpPost(Name = "Logar")]

    public bool Post(LoginDTO login) {
        var conexao = "Host=localhost;Username=postgres;Password=102030;Database=DBChat_Test";
        var con = new NpgsqlConnection (conexao);
        con.Open();
        var comando = new NpgsqlCommand ($"Select 1 from public.login where username='{login.Login}' and senha='{login.Senha}'", con);
        var resultado = int.TryParse(comando.ExecuteScalar()?.ToString(),out int Result);
        con.Close ();

        return resultado;
    }
}