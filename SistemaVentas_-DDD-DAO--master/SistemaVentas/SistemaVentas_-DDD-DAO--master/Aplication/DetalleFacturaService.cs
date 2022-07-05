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
    public class DetalleFacturaService
    {
        readonly IDetalleFacturaRepository DetalleFacturaRepository;
        public DetalleFacturaService()
        {
            DetalleFacturaRepository = new DetalleFacturaRepository();
        }
        public DetalleFactura CopiarDetallePedido(DetallePedido detallepedido)
        {
            if (detallepedido!=null)
            {
                return new DetalleFactura()
                {
                    Material = new Material() { ID_Material = detallepedido.Material.ID_Material ,Nombre= detallepedido.Material.Nombre},
                    Cantidad = detallepedido.Cantidad,
                    PrecioUnit = detallepedido.PrecioUnit,
                    SubTotal = detallepedido.SubTotal
                };
            }
            else return null;
 
        }
        public bool RegistrarDetalleFactura(DetalleFactura detallefactura,int NroFactura)
        {
            if (detallefactura != null)
            {
                return new DetalleFacturaRepository().REGISTRAR_DetalleFactura(detallefactura, NroFactura);
            }
            else return false;

        }
        public List<DetalleFactura> BuscarDetalleFactura(int IDFactura)
        {
            if (!String.IsNullOrEmpty(IDFactura.ToString()))
            {
                return new DetalleFacturaRepository().BuscarDetalleFactura(IDFactura);
            }
            else 
            {
                return null;
            }
            
        }
    }
}
