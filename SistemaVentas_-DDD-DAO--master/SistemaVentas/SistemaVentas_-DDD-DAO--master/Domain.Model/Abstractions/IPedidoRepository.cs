using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Abstractions
{
    public interface IPedidoRepository
    {
        int RegistrarPedido(Pedido OBJpedido);

        List<Pedido> ListarPedidos(String DNI);

        bool AprobarPedido(int ID_PEDIDO);

        bool CancelarPedido(int ID_PEDIDO);

        bool CrearPedido(Pedido OBJpedido);

        DetallePedido ComprobarLimitePedido();

        bool NotificarCancelacionPedido();

        bool AgregarDetallePedido(int ID_Pedido, int Cantidad);

        bool VerificarEstadoPedido(string valor);
    }
}
