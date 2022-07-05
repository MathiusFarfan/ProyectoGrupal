using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class LimiteVenta
    {
        public int ID_LimiteVenta { get; set; }
        public virtual Material Material { get; private set; }
        public double Porcentaje { get; set; }
        public double DescPorcentaje { get; set; }
        public DateTime FechaUltimoCambio { get; set; }
    }
}
