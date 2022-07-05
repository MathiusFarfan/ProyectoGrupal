using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.ViewModel
{
    public class RegistroClienteViewModel
    {
        public int UsuarioID { get; set; }
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dirección { get; set; }
        public string EMAIL { get; set; }
        public string Celular { get; set; }
        public string Contrasena { get; set; }
    }
}
