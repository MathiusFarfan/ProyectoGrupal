using Domain.Model.Abstractions;
using Domain.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplication
{
    public class LimiteVentaService
    {
        readonly ILimiteVentaRepository LimiteVentaRepository;
        public LimiteVentaService()
        {
            LimiteVentaRepository = new LimiteVentaRepository();
        }
        public LimiteVenta BuscarLimitesVenta(int ID_M) 
        {
            try
            {
                if (ID_M .ToString()!= null)
                {
                    return LimiteVentaRepository.BuscarLimitesVenta(ID_M);
                }
                else return null;
            }
            catch 
            {
                return null;
            }
        }
    }
}
