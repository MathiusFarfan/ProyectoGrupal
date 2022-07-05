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
    public class EmpleadoService
    {
        readonly IEmpleadosRepository EmpleadoRepository;
        public EmpleadoService()
        {
            EmpleadoRepository = new EmpleadoRepository();
        }
        public bool RegistrarEmpleado(string Cargo, string Area, string DNI, string Nombre, string Apellido, string Direccion, String Email, String Telefono, String Contrasenia)
        {
            try
            {
                if (!String.IsNullOrEmpty(Cargo) && !String.IsNullOrEmpty(Area))
                {
                    int ID_Usuario = new UsuarioService().RegistrarUsuario(DNI, Nombre, Apellido, Direccion, Email, Telefono, Contrasenia);
                    if (ID_Usuario != -1)
                    {
                        return EmpleadoRepository.RegistrarEmpleado(new Empleado { area = Area, cargo = Cargo }, ID_Usuario);
                    }
                    else return false;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<Empleado> BuscarEmpleado(string Buscar) 
        {
            try
            {
                List<Empleado> empleado_lista = null;
                if (Buscar == "")
                {
                    empleado_lista = new EmpleadoRepository().BuscarEmpleado(Buscar);
                    return empleado_lista;
                }
                else return empleado_lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool DesactivarEmpleado(int ID_Empleado)
        {
            try
            {
                if (ID_Empleado.ToString() != null)
                {
                    return EmpleadoRepository.DesactivarEmpleado(ID_Empleado);
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ActivarEmpleado(int ID_Empleado)
        {
            try
            {
                if (ID_Empleado.ToString() != null)
                {
                    return EmpleadoRepository.ActivarEmpleado(ID_Empleado);
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
