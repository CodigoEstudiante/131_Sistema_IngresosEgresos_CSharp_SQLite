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
    public partial class mdServicioIngreso : Form
    {
        public Servicio oServicio { get; set; }
        public bool servicioNuevo { get; set; }
        public string _tiposervicio { get; set; }
        public mdServicioIngreso(bool nuevo = true, Servicio oservicio = null,string tiposervicio = "INGRESOS")
        {
            servicioNuevo = nuevo;
            oServicio = oservicio;
            _tiposervicio = tiposervicio;
            InitializeComponent();
        }

        private void mdServicioIngreso_Load(object sender, EventArgs e)
        {
            if (oServicio != null)
            {
                txtdescripcion.Text = oServicio.Descripcion;
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;


            if (string.IsNullOrEmpty(txtdescripcion.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar todos los datos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Servicio obj = new Servicio()
            {
                IdServicio = oServicio == null ? 0 : oServicio.IdServicio,
                Descripcion = txtdescripcion.Text,
                TipoServicio = _tiposervicio
            };

            int respuesta = 0;
            if (servicioNuevo)
            {
                respuesta = ServicioLogica.Instancia.Guardar(obj, out mensaje);
            }
            else
            {
                if (ServicioLogica.Instancia.Editar(obj, out mensaje) > 0)
                    respuesta = oServicio.IdServicio;
            }


            if (respuesta > 0)
            {
                obj.IdServicio = respuesta;
                oServicio = obj;
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
