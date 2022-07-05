using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.ViewModel
{
    class RegistroPedidoViewModel
    {
        public int ID_Pedido { set; get; }
        public Cliente Cliente { set; get; }
        public DateTime FechaEstimada { set; get; }
        public double Total_Estimado { set; get; }

    }
}
