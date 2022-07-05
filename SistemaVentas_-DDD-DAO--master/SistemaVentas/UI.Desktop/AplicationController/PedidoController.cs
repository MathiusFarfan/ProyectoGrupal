using Aplication;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.AplicationController
{
    class PedidoController
    {
        public int RegistrarPedido(int _Cliente_ID, int ID_EPedido, int EsPedido, double total_estimado)
        {
            return new PedidoService().RegistrarPedido(_Cliente_ID, ID_EPedido,EsPedido,total_estimado);
        }
        public List<Pedido> ListarPedido(String DNI)
        {
            return new PedidoService().ListarPedidos(DNI);
        }
        public EstadoPedido BuscarEstadoPedido(int Buscar)
        {
            return new EstadoPedidoService().BuscarEstadoPedido(Buscar);
        }
        public bool DesactivarPedido(int ID_PEDIDO)
        {
            return new PedidoService().CancelarPedido(ID_PEDIDO);
        }
        public bool ActivarPedido(int ID_PEDIDO)
        {
            return new PedidoService().AprobarPedido(ID_PEDIDO);
        }
        public bool AgregarDetallePedido(DetallePedido detallepedido)
        {
            return new PedidoService().AgregarDetallePedido(detallepedido);
        }
    }
}
