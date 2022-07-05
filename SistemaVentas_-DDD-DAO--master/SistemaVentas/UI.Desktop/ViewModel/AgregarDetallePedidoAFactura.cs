using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.ViewModel
{
    public class AgregarDetallePedidoAFactura
    {
        public string Buscar { set; get; }
        public string BuscarDate { set; get; }
        public int ID_Pedido { set; get; }
        public List<Pedido> L_Pedido { set; get; }
        public List<DetallePedido> L_DetallePedido { set; get; }
    }
}
