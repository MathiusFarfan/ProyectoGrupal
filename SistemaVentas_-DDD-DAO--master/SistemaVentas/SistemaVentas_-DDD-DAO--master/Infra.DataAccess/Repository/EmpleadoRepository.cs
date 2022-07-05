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
    public class EmpleadoRepository : ConectionSql, IEmpleadosRepository
    {
        public bool ActivarEmpleado(int ID_Empleado)
        {
            bool retornar = false;
            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx = ConectionSql.Objet().Connection();
                SqlCommand command = new SqlCommand("E_ACTIVAR", cnx);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PID_EMPLEADO", SqlDbType.Int).Value = ID_Empleado;
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

        public List<Empleado> BuscarEmpleado(string Buscar)
        {
            List<Empleado> L_empleado = new List<Empleado>();
            SqlDataReader DR;
            SqlConnection SQLCNX = new SqlConnection();
            try
            {
                SQLCNX = ConectionSql.Objet().Connection();
                SqlCommand COMMAND = new SqlCommand("E_BUSCAR", SQLCNX);
                COMMAND.CommandType = CommandType.StoredProcedure;
                COMMAND.Parameters.Add("@PBUSCAR", SqlDbType.VarChar).Value = Buscar;
                SQLCNX.Open();
                DR = COMMAND.ExecuteReader();
                while (DR.Read())
                {
                    L_empleado.Add(new Empleado()
                    {
                        Usuario = new Usuario() {Nombres = DR.GetString(1).ToString(), Apellidos = DR.GetString(2).ToString() },
                        ID_EMPLEADO = DR.GetInt32(0),
                        area=DR.GetString(3),
                        cargo = DR.GetString(4),
                        Estado = DR.GetBoolean(5)
                    });;
                }
                return L_empleado;
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

        public bool DesactivarEmpleado(int ID_Empleado)
        {
            bool retornar = false;

            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx = ConectionSql.Objet().Connection();
                SqlCommand command = new SqlCommand("E_DESACTIVAR", cnx);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PID_EMPLEADO", SqlDbType.Int).Value = ID_Empleado;
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

        public bool RegistrarEmpleado(Empleado OBJEmpleado, int ID_Usuario)
        {
            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx = ConectionSql.Objet().Connection();
                SqlCommand command = new SqlCommand("E_INSERT", cnx);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PCOD_USUARIO", SqlDbType.Int).Value = ID_Usuario;
                command.Parameters.Add("@PAREA", SqlDbType.VarChar).Value = OBJEmpleado.area;
                command.Parameters.Add("@PCARGO", SqlDbType.VarChar).Value = OBJEmpleado.cargo;
                cnx.Open();
                return command.ExecuteNonQuery() == 1 ? true : false;
            }
            catch (Exception EX)
            {
                return false;
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
    }
}
