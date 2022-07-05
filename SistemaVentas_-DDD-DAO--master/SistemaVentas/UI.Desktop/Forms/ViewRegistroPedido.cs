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
    public partial class ViewRegistroPedido : Form
    {
        private int fila;
        static List<DetallePedido> l_detallepedido = new List<DetallePedido>();
        private RegistroPedidoViewModel registropedidomodel = new RegistroPedidoViewModel();
        readonly ClienteController ClienteController;
        readonly PedidoController pedidoController;
        public ViewRegistroPedido()
        {
            InitializeComponent();
            ClienteController = new ClienteController();
            pedidoController = new PedidoController();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDNI.Text))
            {
                BuscarCliente(txtDNI.Text);
            }
            else
            {
                MessageBox.Show("Ingrese su DNI");
                txtDNI.Clear();
            }
        }
        private void BuscarCliente(String dni)
        {
            List<Cliente> Lista = ClienteController.BuscarCliente(dni);
            Cliente r_cliente = null;
            foreach (Cliente cliente in Lista)
            {
                r_cliente = cliente;
            }

            if (r_cliente != null)
            {
                registropedidomodel.Cliente = r_cliente;
                btnAgregarDetallePedido.Visible = true;
                Mostrar();
            }
            else
            {
                MessageBox.Show("No existe el cliente");
            }
        }
        private void Mostrar()
        {
            txtDNI.Text = registropedidomodel.Cliente.Usuario.DNI;
            txtNombre.Text = registropedidomodel.Cliente.Usuario.Nombres;
            txApellido.Text = registropedidomodel.Cliente.Usuario.Apellidos;
            txtCelular.Text = registropedidomodel.Cliente.Usuario.Celular;
            txtGmail.Text = registropedidomodel.Cliente.Usuario.EMAIL;
        }
        private void EliminarDetallePedido()
        {
            fila = dgvDetallePedido.CurrentRow.Index;


            if (MessageBox.Show("Esta seguro de Eliminar", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dgvDetallePedido.Rows.RemoveAt(fila);
                l_detallepedido.RemoveAt(fila);
                MessageBox.Show("Eliminacion correcta");
            }
            else
            {
                MessageBox.Show("Perfecto");
            }

        }

        private void btnAgregarDetallePedido_Click(object sender, EventArgs e)
        {

            MostrarAgregarDetalle();

        }
        public void AddDetallePedido(DetallePedido r_detallepedido)
        {
            if (r_detallepedido != null)
            {

                l_detallepedido.Add(r_detallepedido);
                ListarDetallePedido();
            }
            else
            {
                MessageBox.Show("Hubo un error inesperado");
                btnEliminar.Visible = false;
            }

        }
        public void ListarDetallePedido()
        {
            dgvDetallePedido.Rows.Clear();
            int i = 0;
            double Subtotal = 0;
            foreach (DetallePedido detallepedido in l_detallepedido)
            {
                int x = dgvDetallePedido.Rows.Add();
                dgvDetallePedido.Rows[i].Cells[0].Value = detallepedido.Material.ID_Material;
                dgvDetallePedido.Rows[i].Cells[1].Value = detallepedido.Material.Nombre;
                dgvDetallePedido.Rows[i].Cells[2].Value = detallepedido.Cantidad;
                dgvDetallePedido.Rows[i].Cells[3].Value = detallepedido.PrecioUnit;
                dgvDetallePedido.Rows[i].Cells[4].Value = detallepedido.SubTotal;
                Subtotal += detallepedido.SubTotal;
                i++;
            }
            lvltotalapagar.Text = Subtotal.ToString();
            registropedidomodel.Total_Estimado = Subtotal;
        }
        private void MostrarAgregarDetalle()
        {
            ViewDetallePedido DetallePedido = new ViewDetallePedido();
            AddOwnedForm(DetallePedido);
            DetallePedido.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarDetallePedido();
        }

        private void dgvDetallePedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Visible = true;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            EliminarDetallePedido();
        }

        public void RegistrarPedido()
        {

            registropedidomodel.ID_Pedido = pedidoController.RegistrarPedido(registropedidomodel.Cliente.ID_Cliente,1,1, registropedidomodel.Total_Estimado);
        }
        public void AgregarDetallePedido()
        {
            foreach (DetallePedido detallepedido in l_detallepedido)
            {
                detallepedido.Pedido=new Pedido() { ID_Pedido= registropedidomodel.ID_Pedido};
                if (!pedidoController.AgregarDetallePedido(detallepedido))
                {
                    
                    MessageBox.Show("No se pudo agregar los productos");
                    break;
                }
                else continue;

            }
            LimpiarTodo();

        }
        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if (l_detallepedido.Count > 0)
            {
                RegistrarPedido();
                AgregarDetallePedido();
                LimpiarTodo();
                MessageBox.Show("Pedido Registrado");

            }
            else
            {
                MessageBox.Show("Usted no agregado sus productos");
            }

        }
        private void LimpiarTodo()
        {
            txApellido.Clear();
            txtCelular.Clear();
            txtDNI.Clear();
            txtGmail.Clear();
            txtNombre.Clear();
            LimpiarLista();
            lvltotalapagar.Text = "00.00";
        }
        private void LimpiarLista() 
        {
            for (int i = 0; i < dgvDetallePedido.Rows.Count; i++) 
            {
                dgvDetallePedido.Rows.RemoveAt(fila);
                l_detallepedido.RemoveAt(fila);
            }
            
        }
    }
}
