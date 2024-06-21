namespace Sistema
{
    partial class frmReporteria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbotiporegistro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbotipomoneda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.dgdata = new System.Windows.Forms.DataGridView();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btngenerar = new System.Windows.Forms.Button();
            this.btnexportar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.filtrofechafin = new System.Windows.Forms.DateTimePicker();
            this.filtrofechainicio = new System.Windows.Forms.DateTimePicker();
            this.filtromoneda = new System.Windows.Forms.ComboBox();
            this.filtroconsulta = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnexportarcontable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 1);
            this.panel1.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(12, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(729, 320);
            this.label7.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 40);
            this.label1.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "Consultar por:";
            // 
            // cbotiporegistro
            // 
            this.cbotiporegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotiporegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotiporegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotiporegistro.FormattingEnabled = true;
            this.cbotiporegistro.Location = new System.Drawing.Point(26, 225);
            this.cbotiporegistro.Name = "cbotiporegistro";
            this.cbotiporegistro.Size = new System.Drawing.Size(138, 23);
            this.cbotiporegistro.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tipo Moneda:";
            // 
            // cbotipomoneda
            // 
            this.cbotipomoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipomoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipomoneda.FormattingEnabled = true;
            this.cbotipomoneda.Location = new System.Drawing.Point(175, 225);
            this.cbotipomoneda.Name = "cbotipomoneda";
            this.cbotipomoneda.Size = new System.Drawing.Size(105, 23);
            this.cbotipomoneda.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Fecha Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Fecha Fin:";
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(292, 225);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(104, 23);
            this.txtfechainicio.TabIndex = 104;
            this.txtfechainicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfechainicio_KeyPress);
            // 
            // txtfechafin
            // 
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(406, 225);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(104, 23);
            this.txtfechafin.TabIndex = 105;
            this.txtfechafin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfechafin_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 106;
            this.label5.Text = "Reporte  General";
            // 
            // btnconsultar
            // 
            this.btnconsultar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnconsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconsultar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.ForeColor = System.Drawing.Color.White;
            this.btnconsultar.Location = new System.Drawing.Point(521, 223);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(84, 25);
            this.btnconsultar.TabIndex = 107;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnconsultar.UseVisualStyleBackColor = false;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // dgdata
            // 
            this.dgdata.AllowUserToAddRows = false;
            this.dgdata.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdata.EnableHeadersVisualStyles = false;
            this.dgdata.GridColor = System.Drawing.Color.DimGray;
            this.dgdata.Location = new System.Drawing.Point(24, 266);
            this.dgdata.MultiSelect = false;
            this.dgdata.Name = "dgdata";
            this.dgdata.ReadOnly = true;
            this.dgdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgdata.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgdata.RowTemplate.Height = 30;
            this.dgdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdata.Size = new System.Drawing.Size(704, 198);
            this.dgdata.TabIndex = 108;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(611, 223);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(84, 25);
            this.btnlimpiar.TabIndex = 107;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btngenerar
            // 
            this.btngenerar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btngenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btngenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.ForeColor = System.Drawing.Color.Black;
            this.btngenerar.Image = global::Sistema.Properties.Resources.pdf2_20;
            this.btngenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngenerar.Location = new System.Drawing.Point(590, 474);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(138, 31);
            this.btngenerar.TabIndex = 109;
            this.btngenerar.Text = "Exportar PDF";
            this.btngenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerar.UseVisualStyleBackColor = false;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnexportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.ForeColor = System.Drawing.Color.Black;
            this.btnexportar.Image = global::Sistema.Properties.Resources.excel20;
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.Location = new System.Drawing.Point(446, 474);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(138, 31);
            this.btnexportar.TabIndex = 109;
            this.btnexportar.Text = "Exportar Excel";
            this.btnexportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(729, 63);
            this.label6.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.MidnightBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(12, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(729, 40);
            this.label9.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MidnightBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 15);
            this.label10.TabIndex = 106;
            this.label10.Text = "Reporte  Contable";
            // 
            // filtrofechafin
            // 
            this.filtrofechafin.CustomFormat = "dd/MM/yyyy";
            this.filtrofechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrofechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filtrofechafin.Location = new System.Drawing.Point(406, 102);
            this.filtrofechafin.Name = "filtrofechafin";
            this.filtrofechafin.Size = new System.Drawing.Size(104, 23);
            this.filtrofechafin.TabIndex = 119;
            this.filtrofechafin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtrofechafin_KeyPress);
            // 
            // filtrofechainicio
            // 
            this.filtrofechainicio.CustomFormat = "dd/MM/yyyy";
            this.filtrofechainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrofechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filtrofechainicio.Location = new System.Drawing.Point(292, 102);
            this.filtrofechainicio.Name = "filtrofechainicio";
            this.filtrofechainicio.Size = new System.Drawing.Size(104, 23);
            this.filtrofechainicio.TabIndex = 118;
            this.filtrofechainicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtrofechainicio_KeyPress);
            // 
            // filtromoneda
            // 
            this.filtromoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtromoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtromoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtromoneda.FormattingEnabled = true;
            this.filtromoneda.Location = new System.Drawing.Point(175, 102);
            this.filtromoneda.Name = "filtromoneda";
            this.filtromoneda.Size = new System.Drawing.Size(105, 23);
            this.filtromoneda.TabIndex = 116;
            // 
            // filtroconsulta
            // 
            this.filtroconsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroconsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroconsulta.FormattingEnabled = true;
            this.filtroconsulta.Location = new System.Drawing.Point(26, 102);
            this.filtroconsulta.Name = "filtroconsulta";
            this.filtroconsulta.Size = new System.Drawing.Size(138, 23);
            this.filtroconsulta.TabIndex = 117;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(403, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 112;
            this.label11.Text = "Fecha Fin:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(289, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 113;
            this.label12.Text = "Fecha Inicio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(172, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 15);
            this.label13.TabIndex = 114;
            this.label13.Text = "Tipo Moneda:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 15);
            this.label14.TabIndex = 115;
            this.label14.Text = "Consultar por:";
            // 
            // btnexportarcontable
            // 
            this.btnexportarcontable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnexportarcontable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportarcontable.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnexportarcontable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportarcontable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportarcontable.ForeColor = System.Drawing.Color.Black;
            this.btnexportarcontable.Image = global::Sistema.Properties.Resources.pdf16;
            this.btnexportarcontable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportarcontable.Location = new System.Drawing.Point(534, 100);
            this.btnexportarcontable.Name = "btnexportarcontable";
            this.btnexportarcontable.Size = new System.Drawing.Size(138, 25);
            this.btnexportarcontable.TabIndex = 120;
            this.btnexportarcontable.Text = "Exportar";
            this.btnexportarcontable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarcontable.UseVisualStyleBackColor = false;
            this.btnexportarcontable.Click += new System.EventHandler(this.btnexportarcontable_Click);
            // 
            // frmReporteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(823, 568);
            this.ControlBox = false;
            this.Controls.Add(this.btnexportarcontable);
            this.Controls.Add(this.filtrofechafin);
            this.Controls.Add(this.filtrofechainicio);
            this.Controls.Add(this.filtromoneda);
            this.Controls.Add(this.filtroconsulta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.dgdata);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.txtfechainicio);
            this.Controls.Add(this.cbotipomoneda);
            this.Controls.Add(this.cbotiporegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "frmReporteria";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReporteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbotiporegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbotipomoneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.DataGridView dgdata;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker filtrofechafin;
        private System.Windows.Forms.DateTimePicker filtrofechainicio;
        private System.Windows.Forms.ComboBox filtromoneda;
        private System.Windows.Forms.ComboBox filtroconsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnexportarcontable;
    }
}