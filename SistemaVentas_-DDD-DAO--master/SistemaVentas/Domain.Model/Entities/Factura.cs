using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class Factura
    {
        public int NroFactura { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }
        public int SerieFactura { get; set; }
        public DateTime Fechastatic { get; set; }
        public double Subtotal { get; set; }
        public double Descuento { get; set; }
        public double IGV { get; set; }
        public double CostoTotal { get; set; }
    }
}
