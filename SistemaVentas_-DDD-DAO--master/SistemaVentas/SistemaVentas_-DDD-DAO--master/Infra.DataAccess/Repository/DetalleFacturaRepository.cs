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
    public class DetalleFacturaRepository : ConectionSql, IDetalleFacturaRepository
    {
        public bool REGISTRAR_DetalleFactura(DetalleFactura OBJdetallefactura,int NroFactura)
        {
            bool retornar = false;
            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx = ConectionSql.Objet().Connection();
                SqlCommand command = new SqlCommand("DF_REGISTRAR", cnx);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PNROFACTURA", SqlDbType.SmallInt).Value = NroFactura;
                command.Parameters.Add("@PIDMATERIAL", SqlDbType.Int).Value = OBJdetallefactura.Material.ID_Material;
                command.Parameters.Add("@PCANTIDAD", SqlDbType.Int).Value = OBJdetallefactura.Cantidad;
                command.Parameters.Add("@PPRECIOUNIT", SqlDbType.Decimal).Value = OBJdetallefactura.PrecioUnit;
                command.Parameters.Add("@PSUBTOTAL", SqlDbType.Decimal).Value = OBJdetallefactura.SubTotal;

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

        public List<DetalleFactura> BuscarDetalleFactura(int busqueda)
        {
            SqlDataReader DR;
            SqlConnection SQLCNX = new SqlConnection();
            try
            {
                SQLCNX = ConectionSql.Objet().Connection();
                SqlCommand COMMAND = new SqlCommand("DF_BUSCAR", SQLCNX);
                COMMAND.CommandType = CommandType.StoredProcedure;
                COMMAND.Parameters.Add("@PBUSQUEDA", SqlDbType.SmallInt).Value = busqueda;
                SQLCNX.Open();
                DR = COMMAND.ExecuteReader();

                List<DetalleFactura> ListarDetalleFactura = new List<DetalleFactura>();
                while (DR.Read())
                {
                    ListarDetalleFactura.Add(new DetalleFactura
                    {
                       
                        Material = new Material { Nombre = DR.GetString(0) },
                        Cantidad = DR.GetInt32(1),
                        PrecioUnit = DR.GetDouble(2),
                        SubTotal = DR.GetDouble(3)
                    });
                }
                return ListarDetalleFactura;
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
