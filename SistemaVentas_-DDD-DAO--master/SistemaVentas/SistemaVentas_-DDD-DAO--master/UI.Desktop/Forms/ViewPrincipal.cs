using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.ViewModel;

namespace UI.Desktop.Forms
{
    public partial class ViewPrincipal : Form
    {
        private PrincipalViewModel objprincipal = new PrincipalViewModel();
        public ViewPrincipal()
        {
            InitializeComponent();
        }

        private void ViewPrincipal_Load(object sender, EventArgs e)
        {
            Mostrar_Controles();
        }
        public void CargarVista(int _ID_USER,int _TIPO_PERMISO) 
        {
            objprincipal.TIPO_PERMISO =_TIPO_PERMISO;
            objprincipal.ID_USER = _ID_USER;

        }
        public void Mostrar_Controles() 
        {
            if (objprincipal.TIPO_PERMISO == 1)
            {
                Permiso_1();
            }
            else if (objprincipal.TIPO_PERMISO == 2)
            {
                Permiso_2();
            }
        }
        public void Permiso_1() 
        {
            btnRP.Visible= true;
            btnGC.Visible = false;
            btnGE.Visible = false;
            btnGP.Visible = false;
        }
        public void Permiso_2()
        {
            btnRP.Visible = true;
            btnGC.Visible = true;
            btnGE.Visible = true;
            btnGP.Visible = true;
        }
        private Form Active = null;
        private void ShowForn(Form ChildrenForm)
        {
            if (Active != null)
            {
                Active.Close();
            }
            Active = ChildrenForm;
            ChildrenForm.TopLevel = false;
            ChildrenForm.FormBorderStyle = FormBorderStyle.None;
            ChildrenForm.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(ChildrenForm);
            PanelPrincipal.Tag = ChildrenForm;
            ChildrenForm.BringToFront();
            ChildrenForm.Show();
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            ShowForn(new ViewGestionClientes());
        }

        private void btnGE_Click(object sender, EventArgs e)
        {
            ShowForn(new ViewGestionEmpleados());
        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            ShowForn(new ViewRegistroPedido());
        }

     

        private void btnFactura_Click_1(object sender, EventArgs e)
        {
            ViewRegistroFactura RegistroFactura = new ViewRegistroFactura();
            RegistroFactura.AgregarID(objprincipal.ID_USER);
            ShowForn(RegistroFactura);
        }

        private void btnGP_Click(object sender, EventArgs e)
        {
            ShowForn(new ViewGestionPedidos());
        }
    }
}
