using chatbackend.Repositories.Interface;
using chatbackend.Services.Interface;

namespace chatbackend.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _repository;
        public LoginService(ILoginRepository repository)
        {
            _repository = repository;
        }


        public bool Logar(LoginDTO login)
        {

            if (string.IsNullOrWhiteSpace(login.Usuario) || string.IsNullOrWhiteSpace(login.Senha))
            {

                return false;

            }
                return _repository.Logar(login);
        }

    }
}