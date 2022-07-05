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
    public partial class ViewRegistroMaterial : Form
    {
        private RegistroMaterialesViewModel RegistroMaterialesModel = new RegistroMaterialesViewModel();
        readonly MaterialController MaterialController;
        public ViewRegistroMaterial()
        {
            InitializeComponent();
            MaterialController = new MaterialController();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistroMaterialesModel.Descripcion = txtDescripcion.Text;
            RegistroMaterialesModel.ID_Material = Convert.ToInt32(txtID.Text);
            RegistroMaterialesModel.Nombre = txtNombre.Text;
            RegistroMaterialesModel.PrecioUnit = Convert.ToDouble(txtPrecio.Text);
            RegistroMaterialesModel.Stock = Convert.ToInt32(txtStock.Text);
            RegistroMaterialesModel.Unidad = Convert.ToInt32(txtUnidad.Text);
            Registrar();
        }
        private void Registrar()
        {//DESC = 0
            bool verificar = MaterialController.RegistrarMaterial(txtNombre.Text, txtDescripcion.Text, Convert.ToDouble(txtPrecio.Text), txtUnidad.Text, Convert.ToInt32(txtStock.Text), 0.00);
            if (verificar != false)
            {
                MostrarMensaje("Registro de Empleado Exitoso", true);
                this.Hide();
            }
            else
            {
                MostrarMensaje("Registro de Empleado no Exitoso", false);
                //Limpiar();
            }
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
