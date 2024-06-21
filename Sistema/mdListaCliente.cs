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
    public partial class mdListaCliente : Form
    {
        public string IdPersona { get; set; }
        public string NombreCliente { get; set; }
        public mdListaCliente()
        {
            InitializeComponent();
        }

        private void mdListaCliente_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnseleccionar = new DataGridViewButtonColumn();
            btnseleccionar.HeaderText = "Seleccionar";
            btnseleccionar.Width = 80;
            btnseleccionar.Text = "";
            btnseleccionar.Name = "btnSeleccionar";
            btnseleccionar.UseColumnTextForButtonValue = false;
            
            dgdata.Columns.Add(btnseleccionar);
            dgdata.Columns.Add("Id", "Id");
            dgdata.Columns.Add("Documento", "Documento");
            dgdata.Columns.Add("Nombres", "Nombres");
            dgdata.Columns.Add("Correo", "Correo");


            dgdata.Columns["Documento"].Width = 90;
            dgdata.Columns["Nombres"].Width = 180;
            dgdata.Columns["Correo"].Width = 160;

            dgdata.Columns["Id"].Visible = false;

            foreach (DataGridViewColumn cl in dgdata.Columns)
            {
                if (cl.Visible == true && cl.Name != "btnSeleccionar")
                {
                    cbobuscar.Items.Add(new ComboBoxItem() { Value = cl.Name, Text = cl.HeaderText });
                }
            }
            cbobuscar.DisplayMember = "Text";
            cbobuscar.ValueMember = "Value";
            cbobuscar.SelectedIndex = 0;

            mostrar_personas();

        }

        private void mostrar_personas()
        {

            string mensaje;
            List<Persona> olista = PersonaLogica.Instancia.Listar(out mensaje).Where(p => p.TipoPersona == "CLIENTE").ToList();

            if (string.IsNullOrEmpty(mensaje))
            {
                foreach (Persona op in olista)
                {
                    int rowId = dgdata.Rows.Add();
                    DataGridViewRow row = dgdata.Rows[rowId];

                    row.Cells["Id"].Value = op.IdPersona;
                    row.Cells["Documento"].Value = op.Documento;
                    row.Cells["Nombres"].Value = op.Nombres;
                    row.Cells["Correo"].Value = op.Correo;
                }
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void dgdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.select32.Width;
                var h = Properties.Resources.select32.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.select32, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

        }

        private void dgdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    IdPersona = dgdata.Rows[index].Cells["Id"].Value.ToString();
                    NombreCliente = dgdata.Rows[index].Cells["Nombres"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ComboBoxItem)cbobuscar.SelectedItem).Value.ToString();

            if (dgdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar.Text.ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
