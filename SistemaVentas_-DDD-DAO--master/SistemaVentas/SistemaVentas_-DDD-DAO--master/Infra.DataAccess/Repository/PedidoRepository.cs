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
    public class PedidoRepository : ConectionSql, IPedidoRepository
    {
        public bool NotificarCancelacionPedido() { 
            throw new NotImplementedException(); 
        }

        public List<Pedido> ListarPedidos(String DNI)
        {
            List<Pedido> ListarPedido = new List<Pedido>();
            SqlDataReader DR;
            SqlConnection SQLCNX = new SqlConnection();
            try
            {
                SQLCNX = ConectionSql.Objet().Connection();
                SqlCommand COMMAND = new SqlCommand("P_LISTAR_PEDIDOS", SQLCNX);
                COMMAND.CommandType = CommandType.StoredProcedure;
                COMMAND.Parameters.Add("@DNI", SqlDbType.VarChar).Value = DNI;
                SQLCNX.Open();
                DR = COMMAND.ExecuteReader();
                while (DR.Read())
                {
                    ListarPedido.Add(new Pedido
                    {
                        ID_Pedido = (int)DR.GetInt32(0),
                        Cliente = new Cliente()
                        {
                            Usuario = new Usuario() {Nombres=DR.GetString(1)}
                        },
                        TotalEstimado = (double)DR.GetDecimal(2),
                        FechaEstimada = DR.GetDateTime(3)
                        
                    });
                }
                return ListarPedido;
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
        public bool AprobarPedido(int ID_PEDIDO)
        {
            bool RE;
            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx = ConectionSql.Objet().Connection();
                SqlCommand command = new SqlCommand("P_APROBAR_PEDIDO_GRANDE", cnx);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PID_PEDIDO", SqlDbType.Int).Value = ID_PEDIDO;

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
        public bool CancelarPedido(int ID_PEDIDO)
        {
            bool RE;
            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx = ConectionSql.Objet().Connection();
                SqlCommand command = new SqlCommand("P_CANCELAR_PEDIDO_GRANDE", cnx);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PID_PEDIDO", SqlDbType.Int).Value = ID_PEDIDO;

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

        public int RegistrarPedido(Pedido OBJpedido)
        {
            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx = ConectionSql.Objet().Connection();
                SqlCommand command = new SqlCommand("P_REGISTRAR_PEDIDO", cnx);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PID_CLIENTE", SqlDbType.Int).Value = OBJpedido.Cliente.ID_Cliente;
                command.Parameters.Add("@IDESTADOPEDIDO", SqlDbType.SmallInt).Value = OBJpedido.EstadoPedido.ID_EstadoPedido;
                command.Parameters.Add("@PPEDIDOGRANDE", SqlDbType.Bit).Value = OBJpedido.EsPedidoGrande;
                command.Parameters.Add("@PTOTALNUMERIC", SqlDbType.Decimal).Value = OBJpedido.TotalEstimado;
                cnx.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception EX)
            {
                return -1;
                throw EX;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public bool CrearPedido(Pedido OBJpedido)
        {
            throw new NotImplementedException();
        }

        public DetallePedido ComprobarLimitePedido()
        {
            throw new NotImplementedException();
        }

        public bool AgregarDetallePedido(int ID_Pedido, int Cantidad)
        {
            throw new NotImplementedException();
        }

        public bool VerificarEstadoPedido(string valor)
        {
            throw new NotImplementedException();
        }
    }
}
