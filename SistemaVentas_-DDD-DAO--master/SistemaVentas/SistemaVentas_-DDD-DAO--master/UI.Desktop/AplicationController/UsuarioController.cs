using Aplication;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.AplicationController
{
    public class UsuarioController
    {
        
        public Object[] IniciarUsuario(string gmail, string contrasena)
        {
            return new UsuarioService().IniciarUsuario(gmail,contrasena);
        }
        
    }
}
