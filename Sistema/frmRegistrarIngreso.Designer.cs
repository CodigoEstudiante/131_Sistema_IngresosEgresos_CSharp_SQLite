namespace Sistema
{
    partial class frmRegistrarIngreso
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgdata = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbotipomoneda = new System.Windows.Forms.ComboBox();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdescripcionservicio = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txtidpersona = new System.Windows.Forms.TextBox();
            this.txtidservicio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnverservicios = new System.Windows.Forms.Button();
            this.btnverclientes = new System.Windows.Forms.Button();
            this.btnterminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 1);
            this.panel1.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "Registrar Ingresos";
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
            this.dgdata.ColumnHeadersHeight = 30;
            this.dgdata.EnableHeadersVisualStyles = false;
            this.dgdata.GridColor = System.Drawing.Color.DimGray;
            this.dgdata.Location = new System.Drawing.Point(26, 302);
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
            this.dgdata.Size = new System.Drawing.Size(713, 167);
            this.dgdata.TabIndex = 64;
            this.dgdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdata_CellContentClick);
            this.dgdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgdata_CellPainting);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(12, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(743, 450);
            this.label7.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 40);
            this.label1.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 74;
            this.label8.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 74;
            this.label3.Text = "Servicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "Comentario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 75;
            this.label5.Text = "Tipo Moneda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 74;
            this.label6.Text = "Fecha:";
            // 
            // cbotipomoneda
            // 
            this.cbotipomoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipomoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipomoneda.FormattingEnabled = true;
            this.cbotipomoneda.Location = new System.Drawing.Point(455, 157);
            this.cbotipomoneda.Name = "cbotipomoneda";
            this.cbotipomoneda.Size = new System.Drawing.Size(99, 23);
            this.cbotipomoneda.TabIndex = 76;
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(31, 211);
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(338, 20);
            this.txtcomentario.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 74;
            this.label9.Text = "Monto:";
            // 
            // txtdescripcionservicio
            // 
            this.txtdescripcionservicio.Location = new System.Drawing.Point(31, 159);
            this.txtdescripcionservicio.Name = "txtdescripcionservicio";
            this.txtdescripcionservicio.Size = new System.Drawing.Size(299, 20);
            this.txtdescripcionservicio.TabIndex = 77;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(31, 109);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(299, 20);
            this.txtnombrecliente.TabIndex = 77;
            // 
            // txtfecha
            // 
            this.txtfecha.CustomFormat = "dd/MM/yyyy";
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(455, 106);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(138, 20);
            this.txtfecha.TabIndex = 78;
            this.txtfecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfecha_KeyPress);
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(455, 211);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(140, 20);
            this.txtmonto.TabIndex = 79;
            this.txtmonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonto_KeyPress);
            // 
            // txtidpersona
            // 
            this.txtidpersona.Location = new System.Drawing.Point(82, 88);
            this.txtidpersona.Name = "txtidpersona";
            this.txtidpersona.Size = new System.Drawing.Size(29, 20);
            this.txtidpersona.TabIndex = 80;
            this.txtidpersona.Text = "0";
            this.txtidpersona.Visible = false;
            // 
            // txtidservicio
            // 
            this.txtidservicio.Location = new System.Drawing.Point(118, 136);
            this.txtidservicio.Name = "txtidservicio";
            this.txtidservicio.Size = new System.Drawing.Size(29, 20);
            this.txtidservicio.TabIndex = 80;
            this.txtidservicio.Text = "0";
            this.txtidservicio.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(79, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 81;
            this.label11.Text = "(*)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(495, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "(*)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Sistema.Properties.Resources.cash128;
            this.pictureBox1.Location = new System.Drawing.Point(625, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Sistema.Properties.Resources.new16;
            this.button4.Location = new System.Drawing.Point(560, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 23);
            this.button4.TabIndex = 63;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnverservicios
            // 
            this.btnverservicios.BackColor = System.Drawing.Color.DimGray;
            this.btnverservicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnverservicios.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnverservicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverservicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverservicios.ForeColor = System.Drawing.Color.White;
            this.btnverservicios.Image = global::Sistema.Properties.Resources.searchwhite16;
            this.btnverservicios.Location = new System.Drawing.Point(336, 158);
            this.btnverservicios.Name = "btnverservicios";
            this.btnverservicios.Size = new System.Drawing.Size(33, 20);
            this.btnverservicios.TabIndex = 63;
            this.btnverservicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnverservicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnverservicios.UseVisualStyleBackColor = false;
            this.btnverservicios.Click += new System.EventHandler(this.btnverservicios_Click);
            // 
            // btnverclientes
            // 
            this.btnverclientes.BackColor = System.Drawing.Color.DimGray;
            this.btnverclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnverclientes.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnverclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverclientes.ForeColor = System.Drawing.Color.White;
            this.btnverclientes.Image = global::Sistema.Properties.Resources.searchwhite16;
            this.btnverclientes.Location = new System.Drawing.Point(336, 108);
            this.btnverclientes.Name = "btnverclientes";
            this.btnverclientes.Size = new System.Drawing.Size(33, 20);
            this.btnverclientes.TabIndex = 63;
            this.btnverclientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnverclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnverclientes.UseVisualStyleBackColor = false;
            this.btnverclientes.Click += new System.EventHandler(this.btnverclientes_Click);
            // 
            // btnterminar
            // 
            this.btnterminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnterminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnterminar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnterminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnterminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnterminar.ForeColor = System.Drawing.Color.White;
            this.btnterminar.Image = global::Sistema.Properties.Resources.save16;
            this.btnterminar.Location = new System.Drawing.Point(573, 475);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(166, 29);
            this.btnterminar.TabIndex = 63;
            this.btnterminar.Text = "Terminar y Guardar";
            this.btnterminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnterminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnterminar.UseVisualStyleBackColor = false;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Image = global::Sistema.Properties.Resources.new16;
            this.btnagregar.Location = new System.Drawing.Point(31, 244);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(116, 29);
            this.btnagregar.TabIndex = 63;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // frmRegistrarIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(774, 553);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtidservicio);
            this.Controls.Add(this.txtidpersona);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.txtdescripcionservicio);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.cbotipomoneda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgdata);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnverservicios);
            this.Controls.Add(this.btnverclientes);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistrarIngreso";
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.frmRegistrarIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgdata;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbotipomoneda;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdescripcionservicio;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Button btnverclientes;
        private System.Windows.Forms.Button btnverservicios;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtidpersona;
        private System.Windows.Forms.TextBox txtidservicio;
        private System.Windows.Forms.Button btnterminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}