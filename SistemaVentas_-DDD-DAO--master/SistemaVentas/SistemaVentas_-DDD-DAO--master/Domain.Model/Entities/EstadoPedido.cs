using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class EstadoPedido
    {
        public int ID_EstadoPedido { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
