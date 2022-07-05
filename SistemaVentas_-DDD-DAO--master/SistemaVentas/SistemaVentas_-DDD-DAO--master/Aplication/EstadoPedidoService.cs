using Domain.Model.Abstractions;
using Domain.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    public class EstadoPedidoService
    {
        readonly IEstadoPedidoRepository EstadoPedidoRepository;
        public EstadoPedidoService()
        {
            EstadoPedidoRepository = new EstadoPedidoRepository();
        }
        public EstadoPedido BuscarEstadoPedido(int ID_Pedido)
        {
            try
            {
                if (!String.IsNullOrEmpty(ID_Pedido.ToString()))
                {
                    return new EstadoPedidoRepository().BuscarEstadoPedido(ID_Pedido);
                }
                else return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}