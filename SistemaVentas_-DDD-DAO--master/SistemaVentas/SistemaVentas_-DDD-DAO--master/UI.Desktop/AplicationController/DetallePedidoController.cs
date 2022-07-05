using Aplication;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.AplicationController
{
    public class DetallePedidoController
    {
        public List<DetallePedido> BuscarDetallePedido(int ID_PEDIDO)
        {
            return new DetallePedidoService().BuscarDetallePedido(ID_PEDIDO);
        }

        public bool RegistrarDetallePedido(DetallePedido detallepedido)
        {
            return new DetallePedidoService().RegistrarDetallePedido(detallepedido);

        }
        public DetallePedido CrearDetallePedido(DetallePedido detallepedido)
        {
            return new DetallePedidoService().CrearDetallePedido(detallepedido);

        }
    }
}
