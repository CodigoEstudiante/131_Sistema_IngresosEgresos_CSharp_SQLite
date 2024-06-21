﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Logica;
using Sistema.Modelo;
namespace Sistema
{
    public partial class frmUsuario : Form
    {
        private static Form formularioPadre;
        private static Persona objpersona = new Persona();
        public frmUsuario(Persona obj,Form _formulariopadre)
        {
            formularioPadre = _formulariopadre;
            objpersona = obj;
            InitializeComponent();
        }
        private void frmUsuario_Load(object sender, EventArgs e)
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
            dgdata.Columns.Add("Documento", "Documento");
            dgdata.Columns.Add("Nombres", "Nombres");
            dgdata.Columns.Add("Correo", "Correo");
            dgdata.Columns.Add("Clave", "Clave");
            dgdata.Columns.Add("TipoPersona", "TipoPersona");
            

            dgdata.Columns["Documento"].Width = 100;
            dgdata.Columns["Nombres"].Width = 150;
            dgdata.Columns["Correo"].Width = 150;

            dgdata.Columns["Id"].Visible = false;
            dgdata.Columns["Clave"].Visible = false;

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

            mostrar_personas();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (var form = new mdUsuario(true,null))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Persona obj = form.oPersona;
                    int rowId = dgdata.Rows.Add();
                    DataGridViewRow row = dgdata.Rows[rowId];

                    row.Cells["Id"].Value = obj.IdPersona;
                    row.Cells["Documento"].Value = obj.Documento;
                    row.Cells["Nombres"].Value = obj.Nombres;
                    row.Cells["Correo"].Value = obj.Correo;
                    row.Cells["Clave"].Value = obj.Clave;
                    row.Cells["TipoPersona"].Value = obj.TipoPersona;
                }
            }
        }


        private void mostrar_personas() {

            string mensaje;
            List<Persona> olista = PersonaLogica.Instancia.Listar(out mensaje).Where(p => p.TipoPersona != "CLIENTE").ToList();

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
                    row.Cells["Clave"].Value = op.Clave;
                    row.Cells["TipoPersona"].Value = op.TipoPersona;
                }

            }
            else {

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
                    if (MessageBox.Show("¿Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        int _idpersona = int.Parse(dgdata.Rows[index].Cells["Id"].Value.ToString());
                        int respuesta = PersonaLogica.Instancia.Eliminar(new Persona() {IdPersona = _idpersona },out mensaje);
                        if (respuesta > 0)
                        {
                            dgdata.Rows.RemoveAt(index);
                        }
                        else
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            } else if (dgdata.Columns[e.ColumnIndex].Name == "btnEditar") {

                if (index >= 0)
                {
                    Persona opersona = new Persona()
                    {
                        IdPersona = int.Parse(dgdata.Rows[index].Cells["Id"].Value.ToString()),
                        Documento = dgdata.Rows[index].Cells["Documento"].Value.ToString(),
                        Nombres = dgdata.Rows[index].Cells["Nombres"].Value.ToString(),
                        Correo = dgdata.Rows[index].Cells["Correo"].Value.ToString(),
                        Clave = dgdata.Rows[index].Cells["Clave"].Value.ToString(),
                        TipoPersona = dgdata.Rows[index].Cells["TipoPersona"].Value.ToString()
                    };

                    using (var form = new mdUsuario(false, opersona))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Persona obj = form.oPersona;

                            if (objpersona.IdPersona == obj.IdPersona)
                            {
                                if (MessageBox.Show("El usuario que esta logueado actualmente fue modificado,\nel sistema cerrará sesión automaticamente para obtener los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                {
                                    formularioPadre.Close();
                                }
                            }
                            else {
                                dgdata.Rows[index].Cells["Id"].Value = obj.IdPersona;
                                dgdata.Rows[index].Cells["Documento"].Value = obj.Documento;
                                dgdata.Rows[index].Cells["Nombres"].Value = obj.Nombres;
                                dgdata.Rows[index].Cells["Correo"].Value = obj.Correo;
                                dgdata.Rows[index].Cells["Clave"].Value = obj.Clave;
                                dgdata.Rows[index].Cells["TipoPersona"].Value = obj.TipoPersona;
                            }

                            


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
