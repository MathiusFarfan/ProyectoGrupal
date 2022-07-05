using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.ViewModel
{
    public class RegistroFacturaViewModel
    {
        public int NroFactura { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }
        public int SerieFactura { get; set; }
        public double Subtotal { get; set; }
        public double Descuento { get; set; }
        public double IGV { get; set; }
        public double CostoTotal { get; set; }
        
    }
}
