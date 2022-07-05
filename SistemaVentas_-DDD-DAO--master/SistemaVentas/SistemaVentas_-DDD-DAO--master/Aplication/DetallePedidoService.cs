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
            if (!String.IsNullOrEmpty(ID_PEDIDO.ToString()))
            {
                return new DetallePedidoRepository().BuscarDetallePedido(ID_PEDIDO);
            }
            else return null;
        }

        public bool RegistrarDetallePedido(DetallePedido detallepedido)
        {
            if (detallepedido != null) 
            {
                bool estado = new MaterialService().ReservarMaterial(detallepedido.Cantidad,detallepedido.Material.ID_Material);
                if (estado)
                {
                    return new DetallePedidoRepository().RegistrarDetallePedido(detallepedido);
                }
                else return false;
            }
            else return false;
            
        }
        public DetallePedido CrearDetallePedido(DetallePedido detallepedido)
        {
            if (detallepedido.Cantidad>=0 && detallepedido.PrecioUnit >=0  && detallepedido.SubTotal>=0)
            {
                double SubTotal = CalcularSubtotal(detallepedido.PrecioUnit, detallepedido.Cantidad);
                detallepedido.SubTotal = SubTotal;
                return detallepedido;

            }
            else return null;

        }
        public double CalcularSubtotal(double PrecioUnit,double Cantidad)
        {
            return PrecioUnit * Cantidad;
        }
    
    }
}
