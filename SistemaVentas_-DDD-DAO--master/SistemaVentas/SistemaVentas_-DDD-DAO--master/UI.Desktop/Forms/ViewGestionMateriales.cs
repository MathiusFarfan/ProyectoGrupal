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
    public partial class ViewGestionMateriales : Form
    {
        readonly MaterialController MaterialController;
        private GestionMaterialesViewModel materialmodel = new GestionMaterialesViewModel();
        public ViewGestionMateriales()
        {
            InitializeComponent();
            MaterialController = new MaterialController();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvMateriales.Rows.Clear();
            ListarMateriales(txtBuscar.Text);
        }
        private void ListarMateriales(string busqueda)
        {
            materialmodel.st_Busqueda = busqueda;

            List<Material> lista = new List<Material>();
            lista = MaterialController.BuscarMaterial(busqueda);

            if (lista.Count > 0 && lista != null)
            {
                int i = 0;
                foreach (Material material in lista)
                {
                    int x = dgvMateriales.Rows.Add();
                    //dgvMateriales.Rows[i].Cells[0].Value = material.ID_Cliente;
                    dgvMateriales.Rows[i].Cells[0].Value = material.ID_Material;
                    dgvMateriales.Rows[i].Cells[1].Value = material.Nombre;
                    dgvMateriales.Rows[i].Cells[2].Value = material.Descripcion;
                    dgvMateriales.Rows[i].Cells[3].Value = material.PrecioUnit;
                    dgvMateriales.Rows[i].Cells[4].Value = material.Unidad;
                    dgvMateriales.Rows[i].Cells[5].Value = material.Stock;
                    i++;
                }
            }
            else
            {
                MessageBox.Show("Ocurrio un error Inesperado");
            }
        }
        private void MostrarRegistroMaterial()
        {
            ViewRegistroMaterial RegistroMaterial = new ViewRegistroMaterial();
            AddOwnedForm(RegistroMaterial);
            RegistroMaterial.Show();
        }

        private void dgvMateriales_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow valor in dgvMateriales.SelectedRows)
            {
                materialmodel.int_Id_MaterialSeleccionado = (int)valor.Cells[0].Value;
            }
        }
    }
}
