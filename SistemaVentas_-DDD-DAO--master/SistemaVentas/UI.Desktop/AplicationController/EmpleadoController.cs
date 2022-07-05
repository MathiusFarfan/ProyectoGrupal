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
    class EmpleadoController
    {
        
        public bool RegistrarEmpleado(string DNI, string nombres, string apellidos, string direccion, string gmail, string celular, string contrasena, string area, string cargo)
        {
            return new EmpleadoService().RegistrarEmpleado(area, cargo,DNI, nombres,apellidos,direccion,gmail,celular, contrasena);
        }
        public List<Empleado> BuscarEmpleado(string Buscar)
        {
            return new EmpleadoService().BuscarEmpleado(Buscar);
        }
        public bool DesactivarEmpleado(int ID_Empleado)
        {
            return new EmpleadoService().DesactivarEmpleado(ID_Empleado);
        }
        public bool ActivarEmpleado(int ID_Empleado)
        {
            return new EmpleadoService().ActivarEmpleado(ID_Empleado);
        }
        
    }
}
