using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.ViewModel
{
    public class DetallePedidoViewModel
    {
        public Pedido Pedido { get; set; }
        public Material Material { get; set; }
        public string Nombre { get; set; }
        public string Unidad { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnit { get; set; }
        public double SubTotal { get; set; }
    }
}
