using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Sistema.Logica;
using Sistema.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmReporteria : Form
    {
        public frmReporteria()
        {
            InitializeComponent();
        }

        public static DataTable data;

        private void frmReporteria_Load(object sender, EventArgs e)
        {
            cbotiporegistro.Items.Add(new ComboBoxItem() { Value = "0", Text = "Todos" });
            cbotiporegistro.Items.Add(new ComboBoxItem() { Value = "INGRESOS", Text = "Ingresos" });
            cbotiporegistro.Items.Add(new ComboBoxItem() { Value = "EGRESOS", Text = "Egresos" });
            cbotiporegistro.DisplayMember = "Text";
            cbotiporegistro.ValueMember = "Value";
            cbotiporegistro.SelectedIndex = 0;


     

            string mensaje = string.Empty;
            cbotipomoneda.Items.Clear();
            List<TipoMoneda> olista = TipoMonedaLogica.Instancia.Listar(out mensaje);
            if (olista.Count > 0)
            {
                cbotipomoneda.Items.Add(new ComboBoxItem() { Value = "0", Text = "Todos" });
                foreach (TipoMoneda tm in olista)
                {
                    cbotipomoneda.Items.Add(new ComboBoxItem() { Value = tm.Descripcion, Text = tm.Descripcion });
                }
                cbotipomoneda.DisplayMember = "Text";
                cbotipomoneda.ValueMember = "Value";
                cbotipomoneda.SelectedIndex = 0;
            }



            filtroconsulta.Items.Add(new ComboBoxItem() { Value = "INGRESOS", Text = "Ingresos" });
            filtroconsulta.Items.Add(new ComboBoxItem() { Value = "EGRESOS", Text = "Egresos" });
            filtroconsulta.DisplayMember = "Text";
            filtroconsulta.ValueMember = "Value";
            filtroconsulta.SelectedIndex = 0;

            
            filtromoneda.Items.Clear();
            if (olista.Count > 0)
            {
                foreach (TipoMoneda tm in olista)
                {
                    filtromoneda.Items.Add(new ComboBoxItem() { Value = tm.Descripcion, Text = tm.Descripcion });
                }
                filtromoneda.DisplayMember = "Text";
                filtromoneda.ValueMember = "Value";
                filtromoneda.SelectedIndex = 0;
            }


        }

        private void txtfechainicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtfechafin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cbotiporegistro.SelectedIndex = 0;
            cbotipomoneda.SelectedIndex = 0;
            txtfechainicio.Value = DateTime.Now;
            txtfechafin.Value = DateTime.Now;

            dgdata.DataSource = null;
            data = new DataTable();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(txtfechainicio.Value.ToString("dd/MM/yyyy"), new CultureInfo("es-PE"));
            DateTime dt2 = Convert.ToDateTime(txtfechafin.Value.ToString("dd/MM/yyyy"), new CultureInfo("es-PE"));

            data = ReporteLogica.Instancia.consulta(
                dt1.ToString("yyyy-MM-dd", new CultureInfo("en-US")),
                dt2.ToString("yyyy-MM-dd", new CultureInfo("en-US")),
                ((ComboBoxItem)cbotiporegistro.SelectedItem).Value.ToString(),
                ((ComboBoxItem)cbotipomoneda.SelectedItem).Value.ToString());

            dgdata.DataSource = data;

        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dgdata.Rows.Count > 0)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Reporte_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files|*.xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(data, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("No existen datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgdata.Rows.Count < 1)
                {
                    MessageBox.Show("No existen datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteGeneral_{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));


                string tr = string.Empty;
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow r in data.Rows)
                    {
                        tr += "<tr>";
                        tr += "<td>" + r[0].ToString() + "</td>";
                        tr += "<td>" + r[1].ToString() + "</td>";
                        tr += "<td>" + r[2].ToString() + "</td>";
                        tr += "<td>" + r[3].ToString() + "</td>";
                        tr += "<td>" + r[4].ToString() + "</td>";
                        tr += "<td>" + r[5].ToString() + "</td>";
                        tr += "<td>" + r[6].ToString() + "</td>";
                        tr += "<td>" + r[7].ToString() + "</td>";
                        tr += "<td>" + r[8].ToString() + "</td>";
                        tr += "<td>" + r[9].ToString() + "</td>";
                        tr += "</tr>";
                    }
                }


                string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@filas", tr);

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        //Creamos un nuevo documento y lo definimos como PDF
                        Document pdfDoc = new Document(PageSize.A4.Rotate(), 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void filtrofechainicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void filtrofechafin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnexportarcontable_Click(object sender, EventArgs e)
        {

            try
            {

                DataTable datacontable = new DataTable();
                DateTime dt1 = Convert.ToDateTime(filtrofechainicio.Value.ToString("dd/MM/yyyy"), new CultureInfo("es-PE"));
                DateTime dt2 = Convert.ToDateTime(filtrofechafin.Value.ToString("dd/MM/yyyy"), new CultureInfo("es-PE"));

                datacontable = ReporteLogica.Instancia.contable(
                    dt1.ToString("yyyy-MM-dd", new CultureInfo("en-US")),
                    dt2.ToString("yyyy-MM-dd", new CultureInfo("en-US")),
                    ((ComboBoxItem)filtroconsulta.SelectedItem).Value.ToString().ToUpper(),
                    ((ComboBoxItem)filtromoneda.SelectedItem).Value.ToString().ToUpper());


                if (datacontable.Rows.Count < 1)
                {
                    MessageBox.Show("No existen datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteContable_{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

                decimal monto = 0;
                string tr = string.Empty;
                if (datacontable.Rows.Count > 0)
                {
                    foreach (DataRow r in datacontable.Rows)
                    {
                        tr += "<tr>";
                        tr += "<td>" + r[0].ToString() + "</td>";
                        tr += "<td>" + r[1].ToString() + "</td>";
                        tr += "<td>" + r[2].ToString() + "</td>";
                        tr += "<td>" + r[3].ToString() + "</td>";
                        tr += "</tr>";

                        monto += Convert.ToDecimal(r[3].ToString(), new CultureInfo("es-PE"));
                    }
                }


                string htmltexto = Properties.Resources.PlantillaContable.ToString();
                htmltexto = htmltexto.Replace("@fechainicio", dt1.ToString("dd/MM/yyyy", new CultureInfo("es-PE")));
                htmltexto = htmltexto.Replace("@fechafin", dt2.ToString("dd/MM/yyyy", new CultureInfo("es-PE")));
                htmltexto = htmltexto.Replace("@tiporegistro", ((ComboBoxItem)filtroconsulta.SelectedItem).Value.ToString().ToUpper());
                htmltexto = htmltexto.Replace("@tipomoneda", ((ComboBoxItem)filtromoneda.SelectedItem).Value.ToString().ToUpper());
                htmltexto = htmltexto.Replace("@filas", tr);
                htmltexto = htmltexto.Replace("@total", monto.ToString("0.00", new CultureInfo("es-PE")));

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        using (StringReader sr = new StringReader(htmltexto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }




        }
    }
}
