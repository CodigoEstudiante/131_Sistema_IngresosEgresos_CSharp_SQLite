namespace Sistema
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngresos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEgresos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuCliente,
            this.menuServicios,
            this.menuIngresos,
            this.menuEgresos,
            this.menuReportes});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(119, 514);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // menuUsuario
            // 
            this.menuUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.menuUsuario.AutoSize = false;
            this.menuUsuario.ForeColor = System.Drawing.Color.White;
            this.menuUsuario.Image = global::Sistema.Properties.Resources.usuario48;
            this.menuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(116, 67);
            this.menuUsuario.Text = "Usuarios";
            this.menuUsuario.Click += new System.EventHandler(this.menuUsuario_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.menuCliente.AutoSize = false;
            this.menuCliente.ForeColor = System.Drawing.Color.White;
            this.menuCliente.Image = global::Sistema.Properties.Resources.cliente48;
            this.menuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(116, 67);
            this.menuCliente.Text = "Clientes";
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click);
            // 
            // menuServicios
            // 
            this.menuServicios.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.menuServicios.AutoSize = false;
            this.menuServicios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.egresosToolStripMenuItem});
            this.menuServicios.ForeColor = System.Drawing.Color.White;
            this.menuServicios.Image = global::Sistema.Properties.Resources.servicios48;
            this.menuServicios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuServicios.Name = "menuServicios";
            this.menuServicios.Size = new System.Drawing.Size(116, 67);
            this.menuServicios.Text = "Servicios";
            this.menuServicios.DropDownClosed += new System.EventHandler(this.menuServicios_DropDownClosed);
            this.menuServicios.DropDownOpened += new System.EventHandler(this.menuServicios_DropDownOpened);
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ingresosToolStripMenuItem.Text = "Por Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // egresosToolStripMenuItem
            // 
            this.egresosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.egresosToolStripMenuItem.Name = "egresosToolStripMenuItem";
            this.egresosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.egresosToolStripMenuItem.Text = "Por Egresos";
            this.egresosToolStripMenuItem.Click += new System.EventHandler(this.egresosToolStripMenuItem_Click);
            // 
            // menuIngresos
            // 
            this.menuIngresos.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.menuIngresos.AutoSize = false;
            this.menuIngresos.ForeColor = System.Drawing.Color.White;
            this.menuIngresos.Image = global::Sistema.Properties.Resources.ingresos2_48;
            this.menuIngresos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuIngresos.Name = "menuIngresos";
            this.menuIngresos.Size = new System.Drawing.Size(116, 67);
            this.menuIngresos.Text = "Ingresos";
            this.menuIngresos.Click += new System.EventHandler(this.menuIngresos_Click);
            // 
            // menuEgresos
            // 
            this.menuEgresos.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.menuEgresos.AutoSize = false;
            this.menuEgresos.ForeColor = System.Drawing.Color.White;
            this.menuEgresos.Image = global::Sistema.Properties.Resources.egresos2_48;
            this.menuEgresos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuEgresos.Name = "menuEgresos";
            this.menuEgresos.Size = new System.Drawing.Size(116, 67);
            this.menuEgresos.Text = "Egresos";
            this.menuEgresos.Click += new System.EventHandler(this.menuEgresos_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.menuReportes.AutoSize = false;
            this.menuReportes.ForeColor = System.Drawing.Color.White;
            this.menuReportes.Image = global::Sistema.Properties.Resources.reporte48;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(116, 67);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 514);
            this.Controls.Add(this.Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(894, 553);
            this.MinimumSize = new System.Drawing.Size(894, 553);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuIngresos;
        private System.Windows.Forms.ToolStripMenuItem menuEgresos;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuServicios;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egresosToolStripMenuItem;
    }
}

