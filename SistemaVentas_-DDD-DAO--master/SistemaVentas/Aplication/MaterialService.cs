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
    public class MaterialService
    {
        readonly IMaterialRepository MaterialRepository;
        public MaterialService()
        {
            MaterialRepository = new MaterialRepository();
        }
        public bool ActualizarMaterial(double _preciounit, int ID_Material)
        {
            try
            {
                if (_preciounit >= 0 && ID_Material.ToString() != null)
                {
                    return MaterialRepository.ActualizarMaterial( _preciounit, ID_Material);
                }
                else return false;
            }
            catch
            {
                return false;
            }

        }

        public bool AumentarStock(int ID_Material, int cantidad)
        {
            try
            {
                if (ID_Material.ToString() != null && cantidad >= 0)
                {
                    return MaterialRepository.AumentarStock(ID_Material, cantidad);
                }
                else return false;
            }
            catch
            {
                return false;
            }

        }

        public List<Material> BuscarMaterial(string Buscar)
        {
            try
            {
                if (Buscar != null)
                {
                    List<Material> material_lista = new MaterialRepository().BuscarMaterial(Buscar);
                    if (material_lista.Count < 0)
                    {
                        return null;
                    }
                    else return material_lista;
                }
                else return null;
            }
            catch
            {
                return null;
            }

        }

        public bool RegistrarMaterial(string _nombre, string _descripcion, double _preciounit, string _unidad, int _stock, double _desc)
        {
            try
            {
                if (_nombre != null && _descripcion != null && _preciounit >= 0 && _unidad != null && _stock >= 0 && _desc > 0)
                {
                    return new MaterialRepository().RegistrarMaterial(new Material { Nombre = _nombre, Descripcion = _descripcion, PrecioUnit = _preciounit, Unidad = _unidad, Stock = _stock }, 
                        new LimiteVenta() {DescPorcentaje= _desc });
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
