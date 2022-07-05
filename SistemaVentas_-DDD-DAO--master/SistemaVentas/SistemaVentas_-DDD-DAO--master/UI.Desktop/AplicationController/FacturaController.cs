using Aplication;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.AplicationController
{
    public class FacturaController
    {
        public bool AgregarDetalleFactura(DetalleFactura DetalleFactura,int NroFactura)
        {
            return new FacturaService().AgregarDetalleFactura(DetalleFactura, NroFactura);
        }

        public DetalleFactura AgregarDetallesPedidoAFactura(DetallePedido pedido)
        {
            return new FacturaService().AgregarDetallesPedidoAFactura(pedido);

        }
        public int GenerarFactura(int SerieFactura, int ID_Cliente, int ID_Empleado, double _Subtotal, double _Descuento, double _IGV, double _CostoTotal)
        {
            return new FacturaService().GenerarFactura( SerieFactura,  ID_Cliente,  ID_Empleado,  _Subtotal,  _Descuento,  _IGV,  _CostoTotal);
        }
    }
}
