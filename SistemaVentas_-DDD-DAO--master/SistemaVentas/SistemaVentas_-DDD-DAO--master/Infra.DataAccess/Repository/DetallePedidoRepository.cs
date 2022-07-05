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
    public class DetallePedidoRepository : ConectionSql, IDetallePedidoRepository
    {
        public List<DetallePedido> BuscarDetallePedido(int ID_PEDIDO)
        {
            SqlDataReader DR;
            SqlConnection SQLCNX = new SqlConnection();
            try
            {
                SQLCNX = ConectionSql.Objet().Connection();
                SqlCommand COMMAND = new SqlCommand("DP_BUSCAR_P", SQLCNX);
                COMMAND.CommandType = CommandType.StoredProcedure;
                COMMAND.Parameters.Add("@ID_PEDIDO", SqlDbType.Int).Value = ID_PEDIDO;
                SQLCNX.Open();
                DR = COMMAND.ExecuteReader();

                List<DetallePedido> ListarDetallePedido = new List<DetallePedido>();
                while (DR.Read())
                {
                    ListarDetallePedido.Add(new DetallePedido
                    {
                        Material = new Material { ID_Material = DR.GetInt32(0),Nombre=DR.GetString(1) },
                        PrecioUnit = (double)DR.GetDecimal(3),
                        SubTotal = (double)DR.GetDecimal(4),
                        Cantidad = (int)DR.GetSqlInt16(2),
                    });
                }
                return ListarDetallePedido;
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

        public bool RegistrarDetallePedido(DetallePedido detallepedido)
        {
            bool RE;
            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx = ConectionSql.Objet().Connection();
                SqlCommand command = new SqlCommand("DP_REGISTRAR", cnx);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PCOD_PEDIDO", SqlDbType.Int).Value = detallepedido.Pedido.ID_Pedido;
                command.Parameters.Add("@PID_MATERIAL", SqlDbType.Int).Value = detallepedido.Material.ID_Material;
                command.Parameters.Add("@PCANTIDAD", SqlDbType.Int).Value = detallepedido.Cantidad;
                command.Parameters.Add("@PPRECIOUNIT", SqlDbType.Decimal).Value = detallepedido.PrecioUnit;
                command.Parameters.Add("@SUBTOTAL", SqlDbType.Decimal).Value = detallepedido.SubTotal;
                cnx.Open();
                RE = command.ExecuteNonQuery() == 1 ? true : false;

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
            return RE;
        }
    }
}
