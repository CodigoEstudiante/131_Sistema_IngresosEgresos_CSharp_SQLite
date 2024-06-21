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
    public partial class Form1 : Form
    {
        private static Persona opersona = new Persona();
        public Form1(Persona obj = null)
        {
            opersona = obj == null ? new Persona() { Nombres = "Admin" }:obj;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mostrarformulario(Form formulario, object senderitem)
        {

            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            foreach (ToolStripMenuItem menu in Menu.Items)
            {
                menu.BackColor = Color.CornflowerBlue;
                menu.ForeColor = Color.White;
            }
            ((ToolStripMenuItem)senderitem).BackColor = Color.White;
            ((ToolStripMenuItem)senderitem).ForeColor = Color.Black;

            formulario.MdiParent = this;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.ControlBox = false;
            formulario.Show();
        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            //frmUsuario frm = new frmUsuario();
            //mostrarformulario(frm, sender);
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            mostrarformulario(frm, sender);
        }

        private void menuServicios_DropDownOpened(object sender, EventArgs e)
        {
            menuServicios.ForeColor = Color.Black;
        }

        private void menuServicios_DropDownClosed(object sender, EventArgs e)
        {
            if(menuServicios.BackColor == Color.CornflowerBlue)
                menuServicios.ForeColor = Color.White;
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicioIngresos frm = new frmServicioIngresos();
            mostrarformulario(frm, menuServicios);
        }

        private void egresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicioEgresos frm = new frmServicioEgresos();
            mostrarformulario(frm, menuServicios);
        }

        private void menuIngresos_Click(object sender, EventArgs e)
        {

            frmRegistrarIngreso frm = new frmRegistrarIngreso(opersona);
            mostrarformulario(frm, sender);
        }

        private void menuEgresos_Click(object sender, EventArgs e)
        {
            frmRegistrarEgresos frm = new frmRegistrarEgresos(opersona);
            mostrarformulario(frm, sender);
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            frmReporteria frm = new frmReporteria();
            mostrarformulario(frm, sender);
        }
    }
    
}
