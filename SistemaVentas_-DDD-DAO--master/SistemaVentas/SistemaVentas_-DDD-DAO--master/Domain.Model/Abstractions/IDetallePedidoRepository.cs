using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Abstractions
{
    public interface IDetallePedidoRepository
    {
        bool RegistrarDetallePedido(DetallePedido detallepedido);

        List<DetallePedido> BuscarDetallePedido(int ID_PEDIDO);
    }
}
