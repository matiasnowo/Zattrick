using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Autenticacion
{
    public class UsuarioBE
    {
        public string NUsuario { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Role { get; set; }
        public string Equipo { get; set; }
    }
}
