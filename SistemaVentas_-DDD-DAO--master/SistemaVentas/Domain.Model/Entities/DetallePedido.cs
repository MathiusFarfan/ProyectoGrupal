using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class DetallePedido
    {
        public virtual Pedido Pedido { get; set; }
        public virtual Material Material { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnit { get; set; }
        public double SubTotal { get; set; }
    }
}
