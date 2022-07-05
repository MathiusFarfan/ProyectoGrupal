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
    public partial class ViewRegistroFactura : Form
    {
        public RegistroFacturaViewModel RegistroFacturaModel = new RegistroFacturaViewModel();
        readonly ClienteController ClienteController;
        readonly FacturaController FacturaController;
        public ViewRegistroFactura()
        {
            InitializeComponent();
            ClienteController = new ClienteController();
            FacturaController = new FacturaController();
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
                RegistroFacturaModel.Cliente = r_cliente;
                Mostrar();
            }
            else
            {
                MessageBox.Show("No existe el cliente");
            }
        }
        private void Mostrar()
        {
            txtNombre.Text = RegistroFacturaModel.Cliente.Usuario.Nombres;
            txtapellido.Text = RegistroFacturaModel.Cliente.Usuario.Apellidos;
            txtdireccion.Text = RegistroFacturaModel.Cliente.Usuario.Dirección;
            txtgmail.Text = RegistroFacturaModel.Cliente.Usuario.EMAIL;
        }
        public void AgregarID(int ID_E)
        {
            RegistroFacturaModel.Empleado = new Empleado() { ID_EMPLEADO = ID_E };
        }
        private void ViewRegistroFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {

            if (txtDNI.Text != "")
            {
                String buscar = RegistroFacturaModel.Cliente.Usuario.DNI;
                ViewAgregarDetalleFactura AgregarDetalleFactura = new ViewAgregarDetalleFactura();
                AgregarDetalleFactura.Buscar(buscar);
                AddOwnedForm(AgregarDetalleFactura);
                AgregarDetalleFactura.Show();
            }
            else
            {
                MessageBox.Show("Busque a un cliente");
            }
        }
        public void AgregarDetalle(DetalleFactura detallefactura)
        {
            l_detallesfactura.Add(detallefactura);
        }
        public void ListarDetalleFactura()
        {
            dgvDetalleFactura.Rows.Clear();
            int i = 0;
            double Subtotal = 0;
            double CostoTotal = 0;
            foreach (DetalleFactura detalle in l_detallesfactura)
            {
                int x = dgvDetalleFactura.Rows.Add();
                dgvDetalleFactura.Rows[i].Cells[0].Value = detalle.Material.Nombre;
                dgvDetalleFactura.Rows[i].Cells[1].Value = detalle.Cantidad;
                dgvDetalleFactura.Rows[i].Cells[2].Value = detalle.PrecioUnit;
                dgvDetalleFactura.Rows[i].Cells[3].Value = detalle.SubTotal;
                Subtotal += detalle.SubTotal;
                i++;
            }
            CostoTotal = (Subtotal * 0.18) + Subtotal;
            RegistroFacturaModel.CostoTotal = CostoTotal;
            RegistroFacturaModel.Subtotal = Subtotal;
            lvlcostototal.Text = CostoTotal.ToString();
            lvlsubtotal.Text = Subtotal.ToString();
            RegistroFacturaModel.Descuento = 0;
            RegistroFacturaModel.IGV = 18;
            RegistroFacturaModel.SerieFactura = 2019;
        }
        private void AgregarDetalleFactura()
        {
            foreach (DetalleFactura detalle in l_detallesfactura)
            {

                if (AddDetalleFactura(detalle))
                {
                    continue;
                }
                else
                {

                    MessageBox.Show("Ocurrio un error inesperado");
                    break;
                }
            }
        }
        private bool AddDetalleFactura(DetalleFactura detalle)
        {
            return FacturaController.AgregarDetalleFactura(detalle, RegistroFacturaModel.NroFactura);
        }
        private int GenerarFactura()
        {

            return FacturaController.GenerarFactura(RegistroFacturaModel.SerieFactura, RegistroFacturaModel.Cliente.ID_Cliente,
                RegistroFacturaModel.Empleado.ID_EMPLEADO, RegistroFacturaModel.Subtotal, RegistroFacturaModel.Descuento,
                RegistroFacturaModel.IGV, RegistroFacturaModel.CostoTotal);

        }

        public static List<DetalleFactura> l_detallesfactura = new List<DetalleFactura>();

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (l_detallesfactura.Count > 0)
            {
                int NumF = GenerarFactura();
                if (NumF != -1)
                {
                    RegistroFacturaModel.NroFactura = NumF;
                    AgregarDetalleFactura();
                    MessageBox.Show("Factura Generada");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al generar factura");
                }
            }
            else
            {
                MessageBox.Show("Agrege algo");
            }
        }
        private void Limpiar() 
        {
            txtapellido.Clear();
            txtdireccion.Clear();
            txtDNI.Clear();
            txtgmail.Clear();
            txtNombre.Clear();
            dgvDetalleFactura.Rows.Clear();
            lvlsubtotal.Text = "00.00";
            lvlcostototal.Text = "00.00";
        }
    }
}
