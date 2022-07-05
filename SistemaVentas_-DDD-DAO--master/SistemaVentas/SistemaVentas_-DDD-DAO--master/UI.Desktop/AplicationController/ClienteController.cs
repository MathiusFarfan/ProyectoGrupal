using Aplication;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.AplicationController
{
    public class ClienteController
    {
        
        public List<Cliente> BuscarCliente(string Busqueda) 
        {
            return new ClienteService().BuscarCliente(Busqueda);
        }
        public bool RegistrarCliente(string DNI, string nombres, string apellidos, string direccion, string gmail, string celular, string contrasena)
        {
            return  new ClienteService().RegistrarCliente(DNI, nombres, apellidos, direccion, gmail, celular, contrasena);
        }
        public bool ActualizarCliente(int ID_CLIENTE, string gmail, string celular) 
        {
            return new ClienteService().ActualizarCliente(ID_CLIENTE, gmail, celular);
        }
        

    }
}
