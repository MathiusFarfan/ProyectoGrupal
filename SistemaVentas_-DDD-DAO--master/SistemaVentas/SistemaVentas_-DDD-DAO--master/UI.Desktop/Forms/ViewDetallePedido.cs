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
    public partial class ViewDetallePedido : Form
    {
        private DetallePedidoViewModel detallepedidomodel = new DetallePedidoViewModel();
        readonly MaterialController MaterialController;
        readonly DetallePedidoController DetallePedidoController;
        public ViewDetallePedido()
        {
            InitializeComponent();
            MaterialController = new MaterialController();
            DetallePedidoController = new DetallePedidoController();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarMaterialPorNombre();
            btnAgregar.Enabled =true;
        }
        private void BuscarMaterialPorID()
        {
            MessageBox.Show("Opcion en mantenimiento");
        }
        private void BuscarMaterialPorNombre()
        {
            if (!String.IsNullOrEmpty(txtnombre.Text) && !String.IsNullOrEmpty(txtcantidad.Text))
            {
                BuscarMaterial(txtnombre.Text);
            }
            else 
            {
                MessageBox.Show("Ingrese el nombre del producto o la cantidad");
                Limpiar();
            }
        }
        private void BuscarMaterial(String buscar)
        {
            List<Material> Lista = MaterialController.BuscarMaterial(buscar);
            Material rl_Material = null;
            foreach (Material Material in Lista)
            {
                rl_Material = Material;
            }

            if (rl_Material!= null)
            {

                DetallePedido r_DetallePedido = DetallePedidoController.CrearDetallePedido(new DetallePedido() 
                { 
                  PrecioUnit = rl_Material.PrecioUnit, 
                  Cantidad = int.Parse(txtcantidad.Text),
                  SubTotal=0 
                });

                detallepedidomodel.Material = rl_Material;
                detallepedidomodel.Cantidad = r_DetallePedido.Cantidad;
                detallepedidomodel.PrecioUnit = r_DetallePedido.PrecioUnit;
                detallepedidomodel.SubTotal = r_DetallePedido.SubTotal;

                if (detallepedidomodel.Cantidad <= rl_Material.Stock)
                {
                    VerDetalleBuscado();
                }
                else 
                {
                    MessageBox.Show("No puede sobrepasar el stock");
                    Limpiar();
                }
               

                
            }
            else 
            {
                MessageBox.Show("No existe");
            }
            
        }
        private void VerDetalleBuscado()
        {
            txtnombre.Text = detallepedidomodel.Material.Nombre;
            txtdescripcion.Text = detallepedidomodel.Material.Descripcion;
            txtunidad.Text = detallepedidomodel.Material.Unidad;
            txtstock.Text = detallepedidomodel.Material.Stock.ToString();
            txtpreciounit.Text = detallepedidomodel.PrecioUnit.ToString();
            txtcantidad.Text = detallepedidomodel.Cantidad.ToString();
            txtsubtotal.Text = detallepedidomodel.SubTotal.ToString();

        }
        private void Limpiar() 
        {
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtunidad.Clear();
            txtstock.Clear();
            txtpreciounit.Clear();
            txtsubtotal.Clear();
            txtcantidad.Clear();
        }
        private void Cancelar()
        {
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(detallepedidomodel.Material.ID_Material.ToString()))
            {
                ViewRegistroPedido RegistroPedido = new ViewRegistroPedido();
                DetallePedido detallepedido = ObcDetallePedido();
                RegistroPedido.AddDetallePedido(detallepedido);
                RegistroPedido.ListarDetallePedido();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("No ha seleccionado ningun material");
            }
        }
        private DetallePedido ObcDetallePedido() 
        {
            if (detallepedidomodel!=null)
            {
                return new DetallePedido()
                {
                    Material = detallepedidomodel.Material,
                    PrecioUnit = detallepedidomodel.PrecioUnit,
                    Cantidad = detallepedidomodel.Cantidad,
                    SubTotal = detallepedidomodel.SubTotal
                };
            }
            else 
            {
                MessageBox.Show("No se puego agregar");
                return null;
            }
        }
    }
}
