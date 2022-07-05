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
    public partial class ViewActualizarCliente : Form
    {
        public ActualizarClienteViewModel clienteactualizar = new ActualizarClienteViewModel();
        readonly ClienteController clientecontroller;
        public ViewActualizarCliente()
        {
            InitializeComponent();
            clientecontroller = new ClienteController();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            clienteactualizar.st_Email = txtGmail.Text;
            clienteactualizar.st_Celular = txtTelefono.Text;
            bool rpta = clientecontroller.ActualizarCliente(clienteactualizar.int_Id_Cliente, clienteactualizar.st_Email, clienteactualizar.st_Celular);

            if (rpta != false)
            {
                MostrarMensaje("Actualizacion de Empleado Exitoso", true);
                this.Hide();
            }
            else
            {
                MostrarMensaje("Actualizacion de Empleado no Exitoso", false);
                Limpiar();
            }
        }

        private void ViewActualizarCliente_Load(object sender, EventArgs e)
        {
            
        }
        public void Limpiar() 
        {
            txtGmail.Clear();
            txtTelefono.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void MostrarMensaje(string Mensaje, bool esErrar)
        {
            if (esErrar)
            {
                MessageBox.Show(Mensaje, "Confirmacion", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
