using Domain.Model.Abstractions;
using Domain.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplication
{
    public class PedidoService
    {
        readonly IPedidoRepository PedidoRepository;

        public PedidoService()
        {
            PedidoRepository = new PedidoRepository();
        }
        public int RegistrarPedido(int _ClienteID, int ID_EPedido, int PedidoG, double _TotalEstimado)
        {
            if (!String.IsNullOrEmpty(_ClienteID.ToString()) && !String.IsNullOrEmpty(ID_EPedido.ToString()) && !String.IsNullOrEmpty(PedidoG.ToString()) && _TotalEstimado > 0)
            {
                return new PedidoRepository().RegistrarPedido(new Pedido() { Cliente = new Cliente() { ID_Cliente= _ClienteID }, EstadoPedido= new EstadoPedido() {ID_EstadoPedido= ID_EPedido }, EsPedidoGrande = PedidoG, TotalEstimado = _TotalEstimado });
            }
            else return -2;
        }
        public List<Pedido> ListarPedidos(String DNI)
        {
            try
            {
                if (!String.IsNullOrEmpty(DNI))
                {
                    return new PedidoRepository().ListarPedidos(DNI);
                }
                else 
                {
                    return new PedidoRepository().ListarPedidos("");
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public bool AprobarPedido(int ID_PEDIDO)
        {
            try
            {
                if (ID_PEDIDO >= 0)
                {
                    return new PedidoRepository().AprobarPedido(ID_PEDIDO);
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CancelarPedido(int ID_PEDIDO)
        {
            try
            {
                if (ID_PEDIDO.ToString() != null)
                {
                    return new PedidoRepository().CancelarPedido(ID_PEDIDO);
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public void NotificarCancelacionPedido()
        {
            MessageBox.Show("Pedido Cancelado");
        }
        public bool AgregarDetallePedido(DetallePedido detallepedido)
        {
            if (detallepedido != null)
            {
                return new DetallePedidoService().RegistrarDetallePedido(detallepedido);
            }
            else return false;
        }
        public bool VerificarEstadoPedido(int ID_Pedido)
        {
            if (ID_Pedido .ToString()!= null)
            {
                EstadoPedido estadopedido= new EstadoPedidoService().BuscarEstadoPedido(ID_Pedido);
                if (estadopedido != null) 
                {
                    return true;
                }
                else return false;
            }
            else return false;
            
        }
    }
}
