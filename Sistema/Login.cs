using Sistema.Logica;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtdocumento.Focus();
        }

 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";
            txtdocumento.Focus();
            this.Show();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Persona oPersona = PersonaLogica.Instancia.Listar(out mensaje).Where(p => 
            p.Documento.ToUpper() == txtdocumento.Text && 
            p.Clave.ToUpper() == txtclave.Text.ToUpper() && 
            p.TipoPersona != "CLIENTE").FirstOrDefault();
            if (oPersona != null)
            {
                Inicio frm = new Inicio(oPersona);
                frm.Show();
                this.Hide();
                frm.FormClosing += Frm_Closing;
            }
            else
            {
                if (string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show("No se econtraron coincidencias del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(92, 92, 197);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.MidnightBlue;
        }
    }
}
