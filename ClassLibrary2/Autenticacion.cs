using Model.Autenticacion;

namespace Session
{
    public class Autenticacion
    {
        public bool Autenticar(string username, string password, UsuarioBE usuario)
        {
            if (usuario.Pass == new Encription().StringToSHA(password))
            {
                return true;
            }
            return false;
        } //Autenticación del usuario
    }
}
