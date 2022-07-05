using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class Empleado
    {
        public Usuario Usuario { get; set; }
        public int ID_EMPLEADO { get; set; }
        public string area { get; set; }
        public string cargo { get; set; }
        public bool Estado { get; set; }
    }
}
