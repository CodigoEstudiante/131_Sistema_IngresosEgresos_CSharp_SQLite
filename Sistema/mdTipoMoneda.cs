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
    public partial class mdTipoMoneda : Form
    {
        public mdTipoMoneda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void mdTipoMoneda_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btneliminar = new DataGridViewButtonColumn();
            btneliminar.HeaderText = "Eliminar";
            btneliminar.Width = 60;
            btneliminar.Text = "";
            btneliminar.Name = "btnEliminar";
            btneliminar.UseColumnTextForButtonValue = false;

            dgdata.Columns.Add(btneliminar);
            dgdata.Columns.Add("Id", "Id");
            dgdata.Columns.Add("Descripcion", "Descripcion");
            dgdata.Columns["Id"].Visible = false;

            mostrar();
        }

        private void mostrar() {
            string mensaje;
            dgdata.Rows.Clear();
            List<TipoMoneda> olista = TipoMonedaLogica.Instancia.Listar(out mensaje);

            if (string.IsNullOrEmpty(mensaje))
            {
                foreach (TipoMoneda op in olista)
                {
                    int rowId = dgdata.Rows.Add();
                    DataGridViewRow row = dgdata.Rows[rowId];

                    row.Cells["Id"].Value = op.IdTipoMoneda;
                    row.Cells["Descripcion"].Value = op.Descripcion;
                }
            }
            else
            {

                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;


            if (string.IsNullOrEmpty(txtdescripcion.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar descripcion de moneda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            TipoMoneda obj = new TipoMoneda()
            {
                Descripcion = txtdescripcion.Text.Trim().ToUpper(),
            };

            int respuesta = TipoMonedaLogica.Instancia.Guardar(obj, out mensaje);

            if (respuesta > 0)
            {
                txtdescripcion.Text = "";
                mostrar();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.trash16.Width;
                var h = Properties.Resources.trash16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.trash16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (dgdata.Columns[e.ColumnIndex].Name == "btnEliminar")
            {

                if (index >= 0)
                {
                    if (MessageBox.Show("¿Desea eliminar la moneda?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        int _id = int.Parse(dgdata.Rows[index].Cells["Id"].Value.ToString());
                        int respuesta = TipoMonedaLogica.Instancia.Eliminar(new TipoMoneda() { IdTipoMoneda = _id }, out mensaje);
                        if (respuesta > 0)
                        {
                            dgdata.Rows.RemoveAt(index);
                        }
                        else
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }


        }
    }
}
