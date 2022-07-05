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
    public class DetallePedidoService
    {
        readonly IDetallePedidoRepository DetallePedidoRepository;

        public DetallePedidoService()
        {
            DetallePedidoRepository = new DetallePedidoRepository();
        }
        public List<DetallePedido> BuscarDetallePedido(int ID_PEDIDO)
        {
            

            try
            {
                if (!String.IsNullOrEmpty(ID_PEDIDO.ToString()))
                {
                    return DetallePedidoRepository.BuscarDetallePedido(ID_PEDIDO);
                }
                else return null;
            }
            catch
            {
                return null;
            }
        }

        public bool RegistrarDetallePedido(DetallePedido detallepedido)
        {
            try
            {
                if (detallepedido != null)
                {
                    return DetallePedidoRepository.RegistrarDetallePedido(detallepedido);
                }
                else return false;
            }
            catch
            {
                return false;
            }

        }
        public DetallePedido CrearDetallePedido(DetallePedido detallepedido)
        {
            try
            {
                if (detallepedido.Cantidad >= 0 && detallepedido.PrecioUnit >= 0 && detallepedido.SubTotal >= 0)
                {
                    double SubTotal = CalcularSubtotal(detallepedido.PrecioUnit, detallepedido.Cantidad);
                    detallepedido.SubTotal = SubTotal;
                    return detallepedido;

                }
                else return null;
            }
            catch 
            {
                return null;
            }

        }
        public double CalcularSubtotal(double PrecioUnit,double Cantidad)
        {
            return PrecioUnit * Cantidad;
        }
    
    }
}
