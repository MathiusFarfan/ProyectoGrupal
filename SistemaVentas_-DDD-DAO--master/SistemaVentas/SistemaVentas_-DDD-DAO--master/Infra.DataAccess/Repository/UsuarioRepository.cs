using Domain.Model.Abstractions;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infra.DataAccess.Repository
{
    public class UsuarioRepository : ConectionSql, IUsuarioRepository
    {
        public bool CambiarContrasena(int ID_buscar, string contrasena, byte tp)
        {
            throw new NotImplementedException();
        }

        public Object[] IniciarUsuario(string Email, string contrasena)
        {
            SqlDataReader RD;

            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx = ConectionSql.Objet().Connection();
                SqlCommand command = new SqlCommand("LOG", cnx);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PEMAIL", SqlDbType.VarChar).Value = Email;
                command.Parameters.Add("@PCONTRASENA", SqlDbType.VarChar).Value = contrasena;
                cnx.Open();
                RD = command.ExecuteReader();

                if (RD.Read()) return new Object[] { RD.GetInt32(0), RD.GetInt32(1) };
                else return null;   
            }
            catch (Exception EX)
            {
                return null;
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
        public int RegistroUsuario(Usuario usuario)
        {
            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx = ConectionSql.Objet().Connection();
                SqlCommand command = new SqlCommand("U_REGISTRAR", cnx);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PDNI", SqlDbType.VarChar).Value = usuario.DNI;
                command.Parameters.Add("@PNOMBRES", SqlDbType.VarChar).Value = usuario.Nombres;
                command.Parameters.Add("@PAPELLIDOS", SqlDbType.VarChar).Value = usuario.Apellidos;
                command.Parameters.Add("@PDIRECCION", SqlDbType.VarChar).Value = usuario.Dirección;
                command.Parameters.Add("@PEMAIL", SqlDbType.VarChar).Value = usuario.EMAIL;
                command.Parameters.Add("@PCELULAR", SqlDbType.VarChar).Value = usuario.Celular;
                command.Parameters.Add("@PCONTRASENA", SqlDbType.VarChar).Value = usuario.Contrasena;
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
    }
}
