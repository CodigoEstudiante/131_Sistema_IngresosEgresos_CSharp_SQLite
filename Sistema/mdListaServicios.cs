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
    public partial class mdListaServicios : Form
    {
        public string IdServicio { get; set; }
        public string Descripcion { get; set; }
        private string Tipo = string.Empty;
        public mdListaServicios(string _tipo)
        {
            Tipo = _tipo;
            InitializeComponent();
        }

        private void mdListaServicios_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn btnseleccionar = new DataGridViewButtonColumn();
            btnseleccionar.HeaderText = "Seleccionar";
            btnseleccionar.Width = 80;
            btnseleccionar.Text = "";
            btnseleccionar.Name = "btnSeleccionar";
            btnseleccionar.UseColumnTextForButtonValue = false;

            
            dgdata.Columns.Add(btnseleccionar);
            dgdata.Columns.Add("Id", "Id");
            dgdata.Columns.Add("Descripcion", "Descripcion");


            dgdata.Columns["Descripcion"].Width = 360;

            dgdata.Columns["Id"].Visible = false;

            foreach (DataGridViewColumn cl in dgdata.Columns)
            {
                if (cl.Visible == true && cl.Name != "btnSeleccionar" && cl.Name != "btnEliminar")
                {
                    cbobuscar.Items.Add(new ComboBoxItem() { Value = cl.Name, Text = cl.HeaderText });
                }
            }
            cbobuscar.DisplayMember = "Text";
            cbobuscar.ValueMember = "Value";
            cbobuscar.SelectedIndex = 0;
            mostrar_servicios();
        }


        private void mostrar_servicios()
        {

            string mensaje;
            List<Servicio> olista = ServicioLogica.Instancia.Listar(out mensaje).Where(s => s.TipoServicio == Tipo).ToList();

            if (string.IsNullOrEmpty(mensaje))
            {
                foreach (Servicio op in olista)
                {
                    int rowId = dgdata.Rows.Add();
                    DataGridViewRow row = dgdata.Rows[rowId];

                    row.Cells["Id"].Value = op.IdServicio;
                    row.Cells["Descripcion"].Value = op.Descripcion;
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
                    IdServicio = dgdata.Rows[index].Cells["Id"].Value.ToString();
                    Descripcion = dgdata.Rows[index].Cells["Descripcion"].Value.ToString();
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
