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
    public class EstadoPedidoRepository : ConectionSql, IEstadoPedidoRepository
    {
        public EstadoPedido BuscarEstadoPedido(int ID_Pedido)
        {
            SqlConnection SQLCNX = new SqlConnection();
            try
            {
                SQLCNX = ConectionSql.Objet().Connection();
                SqlCommand COMMAND = new SqlCommand("EP_BUSCAR_ESTADOPEDIDO", SQLCNX);
                COMMAND.CommandType = CommandType.StoredProcedure;
                COMMAND.Parameters.Add("@PID_PEDIDO", SqlDbType.Int).Value = ID_Pedido;
                SQLCNX.Open();
                return new EstadoPedido() {Nombre= (String)COMMAND.ExecuteScalar() };
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
