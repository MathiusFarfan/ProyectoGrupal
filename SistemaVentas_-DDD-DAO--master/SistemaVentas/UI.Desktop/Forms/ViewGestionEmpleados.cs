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
    public partial class ViewGestionEmpleados : Form
    {
        readonly EmpleadoController EmpleadoController;
        public ViewGestionEmpleados()
        {
            InitializeComponent();
            EmpleadoController = new EmpleadoController();
        }

        private void ViewGestionEmpleados_Load(object sender, EventArgs e)
        {
            Desactivar();
            chkSeleccionar.Checked = false;
            dgvEmpleados.Columns[0].Visible = false;
            dgvEmpleados.Rows.Clear();
        }

        private void chkSeleccionar_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkSeleccionar.Checked == true)
            {
                Activar();
                dgvEmpleados.Columns[0].Visible = true;
            }
            else
            {
                Desactivar();
                dgvEmpleados.Columns[0].Visible = false;
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
        private void ActivarEmpleado()
        {
            try
            {
                int contador = 1;
                bool correcto = true;

                int codigo;
                bool Rpta = false;
                foreach (DataGridViewRow row in dgvEmpleados.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        codigo = Convert.ToInt32(row.Cells[1].Value);
                        Rpta = EmpleadoController.ActivarEmpleado(codigo);
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
                    this.Mensaje("No se pudo Activar Correctamente a los Empleados");
                }
                else
                {
                    this.Mensaje("Se pudo Activar Correctamente a los Empleados");
                }
                chkSeleccionar.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DesactivarEmpleado()
        {
            try
            {
                int contador = 1;
                bool correcto = true;

                int codigo;
                bool Rpta = false;
                foreach (DataGridViewRow row in dgvEmpleados.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        codigo = Convert.ToInt32(row.Cells[1].Value);
                        Rpta = EmpleadoController.DesactivarEmpleado(codigo);
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
                    this.Mensaje("No se pudo Activar Correctamente a los Empleados");
                }
                else
                {
                    this.Mensaje("Se pudo Activar Correctamente a los Empleados");
                }
                chkSeleccionar.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            ActivarEmpleado();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            DesactivarEmpleado();
        }
        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        private void ListarEmpleado(string busqueda)
        {
            List<Empleado>  L_Empleado = EmpleadoController.BuscarEmpleado(busqueda);

            if (L_Empleado != null)
            {
                int i = 0;
                foreach (Empleado empleado in L_Empleado)
                {
                    int x = dgvEmpleados.Rows.Add();
                    dgvEmpleados.Rows[i].Cells[1].Value = empleado.ID_EMPLEADO;
                    dgvEmpleados.Rows[i].Cells[2].Value = empleado.Usuario.Nombres;
                    dgvEmpleados.Rows[i].Cells[3].Value = empleado.Usuario.Apellidos;
                    dgvEmpleados.Rows[i].Cells[4].Value = empleado.area;
                    dgvEmpleados.Rows[i].Cells[5].Value = empleado.cargo;
                    if (empleado.Estado)
                    {
                        dgvEmpleados.Rows[i].Cells[6].Value = "Activado";
                    }
                    else
                    {
                        dgvEmpleados.Rows[i].Cells[6].Value = "Desactivado";
                    }
                    i++;
                }
            }
            else 
            {
                MessageBox.Show("Ocurrio un error Inesperado");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();
            ListarEmpleado(txtBuscar.Text);
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ViewRegistroEmpleado RegistroEmpleado = new ViewRegistroEmpleado();
            AddOwnedForm(RegistroEmpleado);
            RegistroEmpleado.Show();
        }
    }
}
