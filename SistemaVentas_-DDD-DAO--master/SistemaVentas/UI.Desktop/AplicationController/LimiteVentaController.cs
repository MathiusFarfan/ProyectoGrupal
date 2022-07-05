using Aplication;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.AplicationController
{
    public class LimiteVentaController
    {
        
        public LimiteVenta BuscarLimitesVenta(int ID_M)
        {
            return new LimiteVentaService().BuscarLimitesVenta(ID_M);
        }
        
    }
}
