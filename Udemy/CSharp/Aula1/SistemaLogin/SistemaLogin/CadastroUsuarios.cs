namespace SistemaLogin
{
     static class CadastroUsuarios
    {
        private static Usuario[] usuarios =   //array de Usuarios com instancia de usuarios 
        {
            new Usuario() { Nome = "Gilberto", Senha = "abc123"},
            new Usuario() { Nome = "Islaine", Senha = "123abc"},
            new Usuario() { Nome = "Juliana", Senha = "a1b2c3"}
        };

        private static Usuario _userLogado = null; //Define o usuario que estará logado no momento

        public static Usuario UsuarioLogado  //Manipula o usuario logado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {   //Este foreach faz a validação se o usuario e a senha são iguais para realizar o login, onde o UsuarioLogado receberá usuario e retornando um true
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;    
                    return true;
                }
            }

            return false;
        }
    }
}
