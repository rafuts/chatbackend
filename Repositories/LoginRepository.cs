using chatbackend.Repositories.Interface;
using Npgsql;
namespace chatbackend.Repositories
{
    public class LoginRepository:ILoginRepository
    {
        public bool Logar(LoginDTO login)
        {
            var conexao = "Host=localhost;Username=postgres;Password=102030;Database=DBChat_Test";
            var con = new NpgsqlConnection(conexao);
            con.Open();
            var comando = new NpgsqlCommand($"Select 1 from public.login where username='{login.Usuario}' and senha='{login.Senha}'", con);
            var resultado = int.TryParse(comando.ExecuteScalar()?.ToString(), out int Result);
            con.Close();
            return resultado;
        }
    }
}
