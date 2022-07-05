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
    public partial class ViewLog : Form
    {
        readonly UsuarioController usuario=new UsuarioController();
        public ViewLog()
        {
            InitializeComponent();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            object[] i = usuario.IniciarUsuario(txt1.Text, txt2.Text);

            if (i != null)
            {
                MessageBox.Show("Sesion Iniciada");
                this.Hide();

                ViewPrincipal objprincipal=new ViewPrincipal();
                objprincipal.CargarVista((int)i[1], (int)i[0]);
                objprincipal.Show();
            }
            else
            {
                MessageBox.Show("No existe");
                //PROBANDO:
                MessageBox.Show("Sesion Iniciada");
                this.Hide();

                ViewPrincipal objprincipal = new ViewPrincipal();
                objprincipal.CargarVista(1, 2);
                objprincipal.Show();
            }
        }

    }
}
