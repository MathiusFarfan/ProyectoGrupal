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
    public partial class ViewRegistroCliente : Form
    {
        private RegistroClienteViewModel clientemodelo = new RegistroClienteViewModel();
        readonly ClienteController clientecontroller;
        public ViewRegistroCliente()
        {
            InitializeComponent();
            clientecontroller = new ClienteController();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clientemodelo.DNI= txtDNI.Text;
            clientemodelo.Nombres = txtNombre.Text;
            clientemodelo.Apellidos = txtApellido.Text;
            clientemodelo.Dirección = txtDireccion.Text;
            clientemodelo.EMAIL = txtGmail.Text;
            clientemodelo.Celular = txtTelefono.Text;
            clientemodelo.Contrasena =txtClave.Text;

            Registrar();


        }
        private void Registrar() 
        {
            bool verificar = clientecontroller.RegistrarCliente(clientemodelo.DNI, clientemodelo.Nombres, clientemodelo.Apellidos,
                clientemodelo.Dirección, clientemodelo.EMAIL, clientemodelo.Celular, clientemodelo.Contrasena);
            if (verificar != false)
            {
                MostrarMensaje("Registro de Cliente Exitoso", true);
                this.Hide();
            }
            else
            {
                MostrarMensaje("Registro de Cliente no Exitoso", false);
                Limpiar();
            }

        }

        private void Limpiar()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtGmail.Clear();
            txtTelefono.Clear();
            txtClave.Clear();
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
