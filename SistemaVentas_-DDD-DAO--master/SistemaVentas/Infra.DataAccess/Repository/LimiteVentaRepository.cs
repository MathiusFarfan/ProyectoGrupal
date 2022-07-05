using Domain.Model.Abstractions;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class LimiteVentaRepository : ConectionSql, ILimiteVentaRepository
    {
        
        public LimiteVenta BuscarLimitesVenta(int ID_M)
        {
            SqlDataReader DR;
            LimiteVenta OBJLimiteVenta = null;
            SqlConnection SQLCNX = new SqlConnection();
            try
            {
                SQLCNX = ConectionSql.Objet().Connection();
                SqlCommand COMMAND = new SqlCommand("LV_BUSCAR", SQLCNX);
                COMMAND.Parameters.Add("@ID", SqlDbType.SmallInt).Value = ID_M;
                SQLCNX.Open();
                DR = COMMAND.ExecuteReader();
                while (DR.Read())
                {
                    OBJLimiteVenta = new LimiteVenta
                    {
                        ID_LimiteVenta = (int)DR.GetInt32(0),
                        Porcentaje = (double)DR.GetDecimal(1),
                        DescPorcentaje = (double)DR.GetDecimal(2),
                        FechaUltimoCambio = DR.GetDateTime(3)
                    };
                }
                return OBJLimiteVenta;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (SQLCNX.State == ConnectionState.Open)
                    SQLCNX.Close();
            }
        }
    }
}
