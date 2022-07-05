using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.ViewModel
{
    public class RegistroMaterialesViewModel
    {
        public int ID_Material { get; set; }
        public LimiteVenta LimiteVenta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnit { get; set; }
        public int Unidad { get; set; }
        public int Stock { get; set; }
    }
}
