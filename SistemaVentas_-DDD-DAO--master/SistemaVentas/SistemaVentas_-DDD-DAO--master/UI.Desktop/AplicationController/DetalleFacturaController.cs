using Aplication;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.AplicationController
{
    public class DetalleFacturaController
    {
        public DetalleFactura CopiarDetallePedido(DetallePedido detallepedido)
        {

            return new DetalleFacturaService().CopiarDetallePedido(detallepedido);

        }
        public bool RegistrarDetallePedido(DetalleFactura detallefactura,int NroFactura)
        {
            return new DetalleFacturaService().RegistrarDetalleFactura(detallefactura, NroFactura);

        }
        public List<DetalleFactura> BuscarDetalleFactura(int IDFactura)
        {
            return new DetalleFacturaService().BuscarDetalleFactura(IDFactura);

        }
    }
}
