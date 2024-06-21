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
    public partial class mdCliente : Form
    {
        public Persona oPersona { get; set; }
        public bool personaNueva { get; set; }
        public mdCliente(bool nuevo = true, Persona opersona = null)
        {
            personaNueva = nuevo;
            oPersona = opersona;
            InitializeComponent();
        }

        private void mdCliente_Load(object sender, EventArgs e)
        {

            if (oPersona != null)
            {
                txtdocumento.Text = oPersona.Documento;
                txtnombres.Text = oPersona.Nombres;
                txtcorreo.Text = oPersona.Correo;

            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;


            if (string.IsNullOrEmpty(txtdocumento.Text.Trim()) || string.IsNullOrEmpty(txtnombres.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar todos los datos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Persona obj = new Persona()
            {
                IdPersona = oPersona == null ? 0 : oPersona.IdPersona,
                Documento = txtdocumento.Text,
                Nombres = txtnombres.Text,
                Correo = txtcorreo.Text,
                Clave = "",
                TipoPersona = "CLIENTE"
            };

            int respuesta = 0;
            if (personaNueva)
            {
                respuesta = PersonaLogica.Instancia.Guardar(obj, out mensaje);
            }
            else
            {
                if (PersonaLogica.Instancia.Editar(obj, out mensaje) > 0)
                    respuesta = oPersona.IdPersona;
            }


            if (respuesta > 0)
            {
                obj.IdPersona = respuesta;
                oPersona = obj;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
