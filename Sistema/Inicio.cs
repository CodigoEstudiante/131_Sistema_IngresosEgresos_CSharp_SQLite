using Sistema.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Inicio : Form
    {
        private static Persona opersona = new Persona();
        private static Button botonmenuactivo = null;
        private static Form formularioactivo = null;
        private int m, mx, my;

        public Inicio(Persona obj = null)
        {
            opersona = obj == null ? new Persona() { Nombres = "Admin" } : obj;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblusuario.Text = opersona.Nombres;
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            panelmenutop.BackColor = Color.FromArgb(20, 20, 95);
            AbrirFormulario(new frmInicio());


            if (opersona.TipoPersona != "ADMINISTRADOR")
            {
                btnusuarios.Visible = false;
                btnserviciosingresos.Visible = false;
                btnserviciosegresos.Visible = false;
                btnreportes.Visible = false;
            }

        }

        private void AbrirFormulario(Form formulariohijo) {
            if (formularioactivo != null) {
                formularioactivo.Close();
            }
            formularioactivo = formulariohijo;
            formulariohijo.TopLevel = false;
            formulariohijo.FormBorderStyle = FormBorderStyle.None;
            formulariohijo.Dock = DockStyle.Fill;
            formulariohijo.BackColor = Color.GhostWhite;
            panelcontenido.Controls.Add(formulariohijo);
            panelcontenido.Tag = formulariohijo;
            formulariohijo.Show();
            lblNombreFormulario.Text = formulariohijo.Text;

        }
        private void BotonActivo(Button botonseleccionado) {
            if (botonmenuactivo != null) {
                botonmenuactivo.BackColor = Color.MidnightBlue;
            }
            botonmenuactivo = botonseleccionado;
            botonseleccionado.BackColor = Color.FromArgb(92,92,197);
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmUsuario(opersona,this));
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmCliente());
        }

        private void btningresos_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmRegistrarIngreso(opersona));
        }

        private void btnegresos_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmRegistrarEgresos(opersona));
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmReporteria());
        }

        private void btnserviciosingresos_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmServicioIngresos());
        }


        private void btnserviciosegresos_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmServicioEgresos());
        }

        private void panelmenutop_MouseDown(object sender, MouseEventArgs e)
        {
            //m = 1;
            //mx = e.X;
            //my = e.Y;
        }

        private void btnacercade_Click(object sender, EventArgs e)
        {
            mdAcercade form = new mdAcercade();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panelmenutop_MouseMove(object sender, MouseEventArgs e)
        {
            //if (m == 1) {
            //    this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            //}
        }


        private void panelmenutop_MouseUp(object sender, MouseEventArgs e)
        {
            //m = 0;
        }
    }
}
