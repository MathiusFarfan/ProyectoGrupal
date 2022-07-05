using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Abstractions
{
    public interface ILimiteVentaRepository
    {
        LimiteVenta BuscarLimitesVenta(int ID_M);
        bool ActualizarLimiteVenta(int ID_M, int CANT);

    }
}
