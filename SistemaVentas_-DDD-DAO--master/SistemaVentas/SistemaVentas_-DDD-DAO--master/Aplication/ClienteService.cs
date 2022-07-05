using Domain.Model.Abstractions;
using Domain.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplication
{
    public class ClienteService
    {
        readonly IClienteRepository ClienteRepository;
        public ClienteService() 
        {
            ClienteRepository = new ClienteRepository();
        }
        public bool RegistrarCliente(string DNI, string Nombre, string Apellido, string Direccion, string Email, string Telefono, string Contrasenia)
        {
            try
            {
                int ID_USUARIO = new UsuarioService().RegistrarUsuario(DNI, Nombre, Apellido, Direccion, Email, Telefono, Contrasenia);
                if (ID_USUARIO != -1)
                {
                    return ClienteRepository.RegistrarCliente(ID_USUARIO);
                }
                else return false; 
            }
            catch 
            {
                return false;
            }
        }
        
        public List<Cliente> BuscarCliente(String buscar) 
        {
            try
            {
                List<Cliente> cliente_lista = null;
                if (buscar=="" || buscar!="") 
                {
                    if (buscar == null)
                    {
                        buscar = "";
                    }
                    else 
                    {
                        cliente_lista = new ClienteRepository().ListarCliente(buscar);
                        return cliente_lista;
                    }
                    return cliente_lista;
                }
                else return null;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public bool ActualizarCliente(int ID_CLIENTE, string gmail, string celular) 
        {
            try
            {
                if (!String.IsNullOrEmpty(ID_CLIENTE.ToString()) && !String.IsNullOrEmpty(gmail) && !String.IsNullOrEmpty(celular))
                {
                    return ClienteRepository.ActualizarCliente(ID_CLIENTE, gmail, celular);
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;

            }
        }
    
    }
}
