using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.AplicationController;
using UI.Desktop.ViewModel;

namespace UI.Desktop.Forms
{
    public partial class ViewAgregarDetalleFactura : Form
    {
        public AgregarDetallePedidoAFactura DetallePedido = new AgregarDetallePedidoAFactura();
        readonly PedidoController PedidoController;
        readonly DetallePedidoController DetallePedidoController;
        readonly FacturaController FacturaController;
        public ViewAgregarDetalleFactura()
        {
            InitializeComponent();
            PedidoController = new PedidoController();
            DetallePedidoController = new DetallePedidoController();
            FacturaController = new FacturaController();
        }

        private void ViewAgregarDetalleFactura_Load(object sender, EventArgs e)
        {
            ListarPedido(DetallePedido.Buscar);
        }
        public void Buscar(String busqueda) 
        {
            DetallePedido.Buscar = busqueda;
        }
        private void ListarPedido(String DNI)
        {
            DetallePedido.L_Pedido = PedidoController.ListarPedido(DNI);
            dgvPedidos.Rows.Clear();
            if (DetallePedido.L_Pedido.Count > 0 && DetallePedido.L_Pedido != null)
            {
                int i = 0;
                foreach (Pedido pedido in DetallePedido.L_Pedido)
                {
                    int x = dgvPedidos.Rows.Add();
                    dgvPedidos.Rows[i].Cells[0].Value = pedido.ID_Pedido;
                    dgvPedidos.Rows[i].Cells[1].Value = pedido.Cliente.Usuario.Nombres;
                    dgvPedidos.Rows[i].Cells[2].Value = pedido.TotalEstimado;
                    dgvPedidos.Rows[i].Cells[3].Value = pedido.FechaEstimada;
                    i++;
                }
            }
        }


        private void ListarDetallePedido(int ID_P)
        {
            DetallePedido.L_DetallePedido = DetallePedidoController.BuscarDetallePedido(ID_P);
            dgvDetallePedido.Rows.Clear();
            if (DetallePedido.L_DetallePedido != null)
            {
                int i = 0;
                foreach (DetallePedido detallepedido in DetallePedido.L_DetallePedido)
                {
                    int x = dgvDetallePedido.Rows.Add();
                    dgvDetallePedido.Rows[i].Cells[0].Value = detallepedido.Material.ID_Material;
                    dgvDetallePedido.Rows[i].Cells[1].Value = detallepedido.Material.Nombre;
                    dgvDetallePedido.Rows[i].Cells[2].Value = detallepedido.Cantidad;
                    dgvDetallePedido.Rows[i].Cells[3].Value = detallepedido.PrecioUnit;
                    dgvDetallePedido.Rows[i].Cells[4].Value = detallepedido.SubTotal;
                    i++;
                }
            }
        }

        private void BuscarFecha()
        {
            dgvPedidos.Rows.Clear();
            if (DetallePedido.L_Pedido.Count > 0 && DetallePedido.L_Pedido != null)
            {
                int i = 0;
                foreach (Pedido pedido in DetallePedido.L_Pedido)
                {
                    string fdh_1 = pedido.FechaEstimada.ToString();
                    string[] fech_1 = fdh_1.Split(' ');
                    string fdh_2 = Calendar.SelectionStart.ToString();
                    string[] fech_2 = fdh_2.Split(' ');

                    if ((DateTime.Compare(DateTime.Parse(fech_1[0]), DateTime.Parse(fech_2[0])))==0)
                    {
                        int x = dgvPedidos.Rows.Add();
                        dgvPedidos.Rows[i].Cells[0].Value = pedido.ID_Pedido;
                        dgvPedidos.Rows[i].Cells[1].Value = pedido.Cliente.Usuario.Nombres;
                        dgvPedidos.Rows[i].Cells[2].Value = pedido.TotalEstimado;
                        dgvPedidos.Rows[i].Cells[3].Value = pedido.FechaEstimada;
                        i++;
                       
                    }
                    else
                    {
                        continue;
                    }
                    
                }
            }
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            BuscarFecha();
        }


        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvPedidos.CurrentRow.Index;
            int ID_Pedido = (int)dgvPedidos.Rows[fila].Cells[0].Value;
            ListarDetallePedido(ID_Pedido);
        }

        private void btnAgregarDetalles_Click(object sender, EventArgs e)
        {
            RangeAgregar();
        }
        public DetalleFactura AgregarDetallePedidoAFactura(DetallePedido detallepedido)
        {
            return FacturaController.AgregarDetallesPedidoAFactura(detallepedido);
        }
        public void RangeAgregar() 
        {
            ViewRegistroFactura RegistroFactura = Owner as ViewRegistroFactura;
            foreach (DetallePedido detallepedido in DetallePedido.L_DetallePedido)
            {
                RegistroFactura.AgregarDetalle(AgregarDetallePedidoAFactura(detallepedido));
            }
            RegistroFactura.ListarDetalleFactura();
            this.Hide();
        }

       
    }
}
