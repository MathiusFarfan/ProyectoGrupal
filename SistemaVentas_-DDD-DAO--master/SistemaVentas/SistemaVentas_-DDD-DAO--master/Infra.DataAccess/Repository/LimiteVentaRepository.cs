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
        public bool ActualizarLimiteVenta(int ID_M, int CANT)
        {
            bool retornar = false;

            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx = ConectionSql.Objet().Connection();
                SqlCommand command = new SqlCommand("LV_ACTUALIZAR", cnx);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PID", SqlDbType.SmallInt).Value = ID_M;
                command.Parameters.Add("@PCANT", SqlDbType.Int).Value = CANT;
                cnx.Open();
                retornar = command.ExecuteNonQuery() == 1 ? true : false;
            }
            catch (Exception EX)
            {
                throw EX;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }


            return retornar;
        }


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
