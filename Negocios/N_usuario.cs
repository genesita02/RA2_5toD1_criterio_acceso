using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class UserService
    {
        private UserRepository IngresarAlSistema = new UserRepository();

        public bool ValidateUser(string usuario, string contraseña)
        {
            User user = IngresarAlSistema.IngresarAlSistema(usuario, contraseña);
            return user != null;
        }
    }
    

}
