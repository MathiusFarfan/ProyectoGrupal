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
    public partial class ViewRegistroEmpleado : Form
    {
        readonly EmpleadoController empleadocontroller;
        private RegistroEmpleadoViewModel empleadomodelo = new RegistroEmpleadoViewModel();
        public ViewRegistroEmpleado()
        {
            InitializeComponent();
            empleadocontroller = new EmpleadoController();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            empleadomodelo.DNI = txtDNI.Text;
            empleadomodelo.Nombres = txtNombre.Text;
            empleadomodelo.Apellidos = txtApellido.Text;
            empleadomodelo.Dirección = txtDireccion.Text;
            empleadomodelo.EMAIL = txtGmail.Text;
            empleadomodelo.Celular = txtTelefono.Text;
            empleadomodelo.Contrasena = txtClave.Text;
            empleadomodelo.Area = txtArea.Text;
            empleadomodelo.Cargo = txtCargo.Text;
            Registrar();
        }
        private void Registrar()
        {
            bool verificar = empleadocontroller.RegistrarEmpleado(txtDNI.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtGmail.Text, txtTelefono.Text, txtClave.Text, txtArea.Text, txtCargo.Text);
            if (verificar != false)
            {
                MostrarMensaje("Registro de Empleado Exitoso", true);
                this.Hide();
            }
            else
            {
                MostrarMensaje("Registro de Empleado no Exitoso", false);
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
            txtArea.Clear();
            txtCargo.Clear();
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
