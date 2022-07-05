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

namespace UI.Desktop.Forms
{
    public partial class ViewGestionPedidos : Form
    {
        readonly PedidoController PedidoController;
        public ViewGestionPedidos()
        {
            InitializeComponent();
            PedidoController = new PedidoController();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarPedido(txtBuscar.Text);

        }

        private void chkSeleccionar_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkSeleccionar.Checked == true)
            {
                Activar();
                dgvPedidos.Columns[0].Visible = true;
            }
            else
            {
                Desactivar();
                dgvPedidos.Columns[0].Visible = false;
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            ActivarPedido();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            DesactivarPedido();
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EstadoPedido estadop = null;
            foreach (DataGridViewRow valor in dgvPedidos.SelectedRows)
            {

                estadop = PedidoController.BuscarEstadoPedido((int)valor.Cells[1].Value);
            }
            if (estadop != null)
            {
                String x = estadop.Nombre;
                txtEstado.Text = x;
            }
            else
            {
                txtEstado.Text = "Estado no encontrado";
            }
        }

        private void ListarPedido(String busqueda)
        {
            dgvPedidos.Rows.Clear();
            List<Pedido> lista = PedidoController.ListarPedido(busqueda);

            if (lista != null)
            {
                int i = 0;
                foreach (Pedido pedido in lista)
                {
                    int x = dgvPedidos.Rows.Add();
                    dgvPedidos.Rows[i].Cells[1].Value = pedido.ID_Pedido;
                    dgvPedidos.Rows[i].Cells[2].Value = pedido.Cliente.Usuario.Nombres;
                    dgvPedidos.Rows[i].Cells[3].Value = pedido.TotalEstimado;
                    dgvPedidos.Rows[i].Cells[4].Value = pedido.FechaEstimada;
                    i++;
                }
            }
            else 
            {
                MessageBox.Show("Error al Listar");
            }
        }
        private void ActivarPedido()
        {
            try
            {
                int contador = 1;
                bool correcto = true;

                int codigo;
                bool Rpta = false;
                foreach (DataGridViewRow row in dgvPedidos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        codigo = Convert.ToInt32(row.Cells[1].Value);
                        Rpta = PedidoController.ActivarPedido(codigo);
                        if (Rpta == true)
                        {
                            contador++;
                        }
                        else
                        {
                            correcto = false;
                        }
                    }
                }
                if (correcto == false)
                {
                    this.Mensaje("No se pudo Activar Correctamente el Pedido");
                }
                else
                {
                    this.Mensaje("Se pudo Activar Correctamente el Pedido");
                }
                chkSeleccionar.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DesactivarPedido()
        {
            try
            {
                int contador = 1;
                bool correcto = true;

                int codigo;
                bool Rpta = false;
                foreach (DataGridViewRow row in dgvPedidos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        codigo = Convert.ToInt32(row.Cells[1].Value);
                        Rpta = PedidoController.DesactivarPedido(codigo);
                        if (Rpta == true)
                        {
                            contador++;
                        }
                        else
                        {
                            correcto = false;
                        }
                    }
                }
                if (correcto == false)
                {
                    this.Mensaje("No se pudo Activar Correctamente a los Pedidos");
                }
                else
                {
                    this.Mensaje("Se pudo Activar Correctamente a los Pedidos");
                }
                chkSeleccionar.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Desactivar()
        {
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
        }

        private void Activar()
        {
            btnActivar.Visible = true;
            btnDesactivar.Visible = true;
        }
        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewGestionPedidos_Load(object sender, EventArgs e)
        {
            dgvPedidos.Columns[0].Visible = false;
        }
    }
}
