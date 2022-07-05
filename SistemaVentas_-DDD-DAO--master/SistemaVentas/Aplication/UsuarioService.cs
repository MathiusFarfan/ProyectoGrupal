using Domain.Model.Abstractions;
using Domain.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    public class UsuarioService
    {
        readonly IUsuarioRepository UsuarioRepository;
        public UsuarioService()
        {
            UsuarioRepository = new UsuarioRepository();
        }
        public int RegistrarUsuario(string _DNI, string _Nombre, string _Apellido, string _Direccion, string _Email, string _Telefono, string _Contrasenia)
        {
            try
            {
                if (!String.IsNullOrEmpty(_DNI) && !String.IsNullOrEmpty(_Nombre) && !String.IsNullOrEmpty(_Apellido) && !String.IsNullOrEmpty(_Direccion) && !String.IsNullOrEmpty(_Email) && !String.IsNullOrEmpty(_Telefono) && !String.IsNullOrEmpty(_Contrasenia))
                {
                    if (_DNI.Length == 8)
                    {
                        return (UsuarioRepository.RegistroUsuario(new Usuario { DNI = _DNI, Nombres = _Nombre, Apellidos = _Apellido, Dirección = _Direccion, EMAIL = _Email, Celular = _Telefono, Contrasena = _Contrasenia }));
                    }
                    else return -1;
                }
                else return -1;
            }
            catch
            {
                return -1;
            }


        }
        public Object[] IniciarUsuario(string Email, string Contrasenia)
        {
            try
            {
                if (!String.IsNullOrEmpty(Email) && !String.IsNullOrEmpty(Contrasenia))
                {
                    return UsuarioRepository.IniciarUsuario(Email, Contrasenia);
                }
                else return null;
            }
            catch 
            {
                return null;
            }
            
        }
        

    }
}
