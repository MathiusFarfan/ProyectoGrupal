using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class Pedido
    {
        public int ID_Pedido { get; set; }
        public virtual Cliente Cliente { get;  set; }
        public virtual EstadoPedido EstadoPedido { get;  set; }
        public int EsPedidoGrande { get; set; }
        public DateTime FechaEstimada { get; set; }
        public double TotalEstimado { get; set; }
        public List<DetallePedido> List_DetallePedido { get;  set; }
    }
}
