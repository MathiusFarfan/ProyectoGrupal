using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class Material
    {
        public int ID_Material { get; set; }
        public LimiteVenta LimiteVenta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnit { get; set; }
        public string Unidad { get; set; }
        public int Stock { get; set; }
    }
}
