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
    public partial class frmServicioIngresos : Form
    {
        public frmServicioIngresos()
        {
            InitializeComponent();
        }

        private void frmServicioIngresos_Load(object sender, EventArgs e)
        {

            //AGREGAR BOTON ELIMINAR
            DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
            btnedit.HeaderText = "Editar";
            btnedit.Width = 50;
            btnedit.Text = "";
            btnedit.Name = "btnEditar";
            btnedit.UseColumnTextForButtonValue = false;

            DataGridViewButtonColumn btneliminar = new DataGridViewButtonColumn();
            btneliminar.HeaderText = "Eliminar";
            btneliminar.Width = 60;
            btneliminar.Text = "";
            btneliminar.Name = "btnEliminar";
            btneliminar.UseColumnTextForButtonValue = false;


            dgdata.Columns.Add(btnedit);
            dgdata.Columns.Add(btneliminar);
            dgdata.Columns.Add("Id", "Id");
            dgdata.Columns.Add("Descripcion", "Descripcion");


            dgdata.Columns["Descripcion"].Width = 500;

            dgdata.Columns["Id"].Visible = false;

            foreach (DataGridViewColumn cl in dgdata.Columns)
            {
                if (cl.Visible == true && cl.Name != "btnEditar" && cl.Name != "btnEliminar")
                {
                    cbobuscar.Items.Add(new ComboBoxItem() { Value = cl.Name, Text = cl.HeaderText });
                }
            }
            cbobuscar.DisplayMember = "Text";
            cbobuscar.ValueMember = "Value";
            cbobuscar.SelectedIndex = 0;
            mostrar_servicios();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            using (var form = new mdServicioIngreso(true, null,"INGRESOS"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Servicio obj = form.oServicio;
                    int rowId = dgdata.Rows.Add();
                    DataGridViewRow row = dgdata.Rows[rowId];

                    row.Cells["Id"].Value = obj.IdServicio;
                    row.Cells["Descripcion"].Value = obj.Descripcion;
                }
            }
        }

        private void mostrar_servicios()
        {

            string mensaje;
            List<Servicio> olista = ServicioLogica.Instancia.Listar(out mensaje).Where(s => s.TipoServicio == "INGRESOS").ToList();

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

                var w = Properties.Resources.edit16.Width;
                var h = Properties.Resources.edit16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 1)
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
                    if (MessageBox.Show("¿Desea eliminar el servicio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        int _id = int.Parse(dgdata.Rows[index].Cells["Id"].Value.ToString());
                        int respuesta = ServicioLogica.Instancia.Eliminar(new Servicio() { IdServicio = _id }, out mensaje);
                        if (respuesta > 0)
                        {
                            dgdata.Rows.RemoveAt(index);
                        }
                        else
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            else if (dgdata.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (index >= 0)
                {
                    Servicio oservicio = new Servicio()
                    {
                        IdServicio = int.Parse(dgdata.Rows[index].Cells["Id"].Value.ToString()),
                        Descripcion = dgdata.Rows[index].Cells["Descripcion"].Value.ToString(),
                        TipoServicio = "INGRESOS"
                    };

                    using (var form = new mdServicioIngreso(false, oservicio, "INGRESOS"))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Servicio obj = form.oServicio;
                            dgdata.Rows[index].Cells["Id"].Value = obj.IdServicio;
                            dgdata.Rows[index].Cells["Descripcion"].Value = obj.Descripcion;

                        }
                    }
                }



            }
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
