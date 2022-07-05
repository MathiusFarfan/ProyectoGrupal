using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Abstractions
{

    public interface IMaterialRepository
    {
        List<Material> BuscarMaterial(string Buscar);
        bool ReservarMaterial(int cantidad, int ID_Material);
        bool AumentarStock(int ID_Material, int cantidad);

        bool ActualizarMaterial(double preciounit, int ID_Material);

        bool RegistrarMaterial(Material OBJMaterial, LimiteVenta OBJlimiteVenta);
    }
}
