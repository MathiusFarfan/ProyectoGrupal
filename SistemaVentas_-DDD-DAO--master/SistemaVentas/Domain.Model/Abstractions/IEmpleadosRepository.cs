using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Abstractions
{
    public interface IEmpleadosRepository
    {
        bool RegistrarEmpleado(Empleado OBJEmpleado, int ID_Usuario);
        List<Empleado> BuscarEmpleado(string Buscar);
        bool DesactivarEmpleado(int ID_Empleado);
        bool ActivarEmpleado(int ID_Empleado);
    }
}
