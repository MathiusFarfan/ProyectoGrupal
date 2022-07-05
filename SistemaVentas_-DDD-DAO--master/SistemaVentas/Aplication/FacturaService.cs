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
    public class FacturaService
    {
        readonly IFacturaRepository FacturaRepository;
        public FacturaService()
        {
            FacturaRepository = new FacturaRepository();
        }
        public bool AgregarDetalleFactura(DetalleFactura DetalleFactura,int NroFactura)
        {
            if (DetalleFactura != null)
            {
                return new DetalleFacturaService().RegistrarDetalleFactura(DetalleFactura,NroFactura);
            }
            else return false;
        }

        public DetalleFactura AgregarDetallesPedidoAFactura(DetallePedido pedido)
        {
            if (pedido != null)
            {
                DetalleFactura detallefactura = new DetalleFacturaService().CopiarDetallePedido(pedido);
                return detallefactura;
            }
            else return null;
            
        }
        public int GenerarFactura(int SerieFactura,int ID_Cliente,int ID_Empleado, double _Subtotal, double _Descuento, double _IGV, double _CostoTotal)
        {
            try
            {
                if (!String.IsNullOrEmpty(SerieFactura.ToString()) && !String.IsNullOrEmpty(ID_Cliente.ToString()) && !String.IsNullOrEmpty(ID_Empleado.ToString()) && _Subtotal >= 0 && _Descuento >= 0 && _IGV >= 0 && _CostoTotal >= 0)
                {
                    return FacturaRepository.GenerarFactura(new Factura() {SerieFactura=SerieFactura,Subtotal= _Subtotal,Descuento= _Descuento,IGV= _IGV,CostoTotal= _CostoTotal, 
                    Cliente=new Cliente() {ID_Cliente=ID_Cliente},Empleado=new Empleado { ID_EMPLEADO=ID_Empleado} });
                }
                else return -2;
            }
            catch 
            {
                return -2;
            }
        }

    }
}
