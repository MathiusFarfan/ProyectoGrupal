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
    public class MaterialController
    {
        
        public bool ActualizarMaterial(double preciounit, int ID_Material)
        {
            
            return new MaterialService().ActualizarMaterial(preciounit,ID_Material);
        }

        public bool AumentarStock(int ID_Material, int cantidad)
        {
            return new MaterialService().AumentarStock(ID_Material, cantidad);
        }

        public List<Material> BuscarMaterial(string Buscar)
        {
            return new MaterialService().BuscarMaterial(Buscar);
        }

        public bool RegistrarMaterial(string nombre, string descripcion, double preciounit, string unidad, int stock, double desc)
        {
            return new MaterialService().RegistrarMaterial(nombre,  descripcion,  preciounit,  unidad,  stock, desc);
        }

        public bool ReservarMaterial(int cantidad, int ID_Material)
        {
            return new MaterialService().ReservarMaterial(cantidad, ID_Material);
        }
        
    }
}
