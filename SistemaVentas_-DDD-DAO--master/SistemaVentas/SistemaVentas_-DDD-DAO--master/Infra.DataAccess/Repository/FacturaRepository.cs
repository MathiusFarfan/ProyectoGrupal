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
    public class FacturaRepository : ConectionSql, IFacturaRepository
    {
        public int GenerarFactura(Factura OBJfactura)
        {
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ConectionSql.Objet().Connection();
                SqlCommand comando = new SqlCommand("F_GENERARFACTURA", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@PSERIEFACTURA", SqlDbType.SmallInt).Value = OBJfactura.SerieFactura;
                comando.Parameters.Add("@PIDCLIENTE", SqlDbType.Int).Value = OBJfactura.Cliente.ID_Cliente;
                comando.Parameters.Add("@IDEMPLEADO", SqlDbType.Int).Value = OBJfactura.Empleado.ID_EMPLEADO;
                comando.Parameters.Add("@PSUBTOTAL", SqlDbType.Decimal).Value = OBJfactura.Subtotal;
                comando.Parameters.Add("@PDESCUENTO", SqlDbType.Decimal).Value = OBJfactura.Descuento;
                comando.Parameters.Add("@PIGV", SqlDbType.Decimal).Value = OBJfactura.IGV;
                comando.Parameters.Add("@PCOSTOTOAL", SqlDbType.Decimal).Value = OBJfactura.CostoTotal;
                sqlCnx.Open();

                return (int)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return -1;
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open)
                {
                    sqlCnx.Close();
                }
            }
        }

    }
}
