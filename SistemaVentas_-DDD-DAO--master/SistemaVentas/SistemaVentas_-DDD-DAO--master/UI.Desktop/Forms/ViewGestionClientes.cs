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
    public partial class ViewGestionClientes : Form
    {
        readonly ClienteController ClienteController;
        private GestionClientesViewModel clientemodel = new GestionClientesViewModel();

        public ViewGestionClientes()
        {
            InitializeComponent();
            ClienteController = new ClienteController();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            ListarClientes(txtBuscar.Text);
        }

        private void ListarClientes(string busqueda)
        {
            clientemodel.st_Busqueda = busqueda;

            List<Cliente> lista = new List<Cliente>();
            lista = ClienteController.BuscarCliente(busqueda);

            if (lista.Count > 0 && lista != null)
            {
                int i = 0;
                foreach (Cliente cliente in lista)
                {
                    int x = dgvClientes.Rows.Add();
                    dgvClientes.Rows[i].Cells[0].Value = cliente.ID_Cliente;
                    dgvClientes.Rows[i].Cells[1].Value = cliente.Usuario.DNI;
                    dgvClientes.Rows[i].Cells[2].Value = cliente.Usuario.Nombres;
                    dgvClientes.Rows[i].Cells[3].Value = cliente.Usuario.Dirección;
                    dgvClientes.Rows[i].Cells[4].Value = cliente.Usuario.Apellidos;
                    dgvClientes.Rows[i].Cells[5].Value = cliente.Usuario.Celular;
                    dgvClientes.Rows[i].Cells[6].Value = cliente.Usuario.EMAIL;
                    i++;
                }

            }
            else 
            {
                MessageBox.Show("Ocurrio un error Inesperado");
            }
        }
        private void MostrarRegistroCliente()
        {
            ViewRegistroCliente RegistroCiente = new ViewRegistroCliente();
            AddOwnedForm(RegistroCiente);
            RegistroCiente.Show();
        }
        private void MostrarActualizarCliente()
        {
            ViewActualizarCliente ActualizarCiente = new ViewActualizarCliente();
            ActualizarCiente.clienteactualizar.int_Id_Cliente = clientemodel.int_Id_ClienteSeleccionado;
            AddOwnedForm(ActualizarCiente);
            ActualizarCiente.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MostrarRegistroCliente();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarActualizarCliente();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow valor in dgvClientes.SelectedRows)
            {
                clientemodel.int_Id_ClienteSeleccionado = (int)valor.Cells[0].Value;
            }
        }

        private void ViewGestionClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
