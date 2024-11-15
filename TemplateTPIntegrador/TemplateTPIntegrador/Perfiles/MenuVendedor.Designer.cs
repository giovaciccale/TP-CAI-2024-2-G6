namespace TemplateTPIntegrador
{
    partial class MenuVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVendedor));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnSeccionCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeccionVentas = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeccionReportes = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.tabVentasPorVendedor = new Guna.UI2.WinForms.Guna2Button();
            this.tabVentas = new Guna.UI2.WinForms.Guna2Button();
            this.tabAgregarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.tabBuscarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuVertical.SuspendLayout();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.menuVertical.Controls.Add(this.btnSeccionCliente);
            this.menuVertical.Controls.Add(this.btnSeccionVentas);
            this.menuVertical.Controls.Add(this.btnSeccionReportes);
            this.menuVertical.Controls.Add(this.label5);
            this.menuVertical.Controls.Add(this.label4);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 650);
            this.menuVertical.TabIndex = 994;
            // 
            // btnSeccionCliente
            // 
            this.btnSeccionCliente.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSeccionCliente.Checked = true;
            this.btnSeccionCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeccionCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeccionCliente.FillColor = System.Drawing.Color.Empty;
            this.btnSeccionCliente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSeccionCliente.ForeColor = System.Drawing.Color.White;
            this.btnSeccionCliente.Location = new System.Drawing.Point(0, 125);
            this.btnSeccionCliente.Name = "btnSeccionCliente";
            this.btnSeccionCliente.Size = new System.Drawing.Size(250, 40);
            this.btnSeccionCliente.TabIndex = 1002;
            this.btnSeccionCliente.Text = "Clientes";
            this.btnSeccionCliente.Click += new System.EventHandler(this.btnSeccionClientes_Click);
            // 
            // btnSeccionVentas
            // 
            this.btnSeccionVentas.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSeccionVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeccionVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeccionVentas.FillColor = System.Drawing.Color.Empty;
            this.btnSeccionVentas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSeccionVentas.ForeColor = System.Drawing.Color.White;
            this.btnSeccionVentas.Location = new System.Drawing.Point(0, 171);
            this.btnSeccionVentas.Name = "btnSeccionVentas";
            this.btnSeccionVentas.Size = new System.Drawing.Size(250, 40);
            this.btnSeccionVentas.TabIndex = 1001;
            this.btnSeccionVentas.Text = "Ventas";
            this.btnSeccionVentas.Click += new System.EventHandler(this.btnSeccionVentas_Click);
            // 
            // btnSeccionReportes
            // 
            this.btnSeccionReportes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSeccionReportes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionReportes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionReportes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeccionReportes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeccionReportes.FillColor = System.Drawing.Color.Empty;
            this.btnSeccionReportes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSeccionReportes.ForeColor = System.Drawing.Color.White;
            this.btnSeccionReportes.Location = new System.Drawing.Point(0, 217);
            this.btnSeccionReportes.Name = "btnSeccionReportes";
            this.btnSeccionReportes.Size = new System.Drawing.Size(250, 40);
            this.btnSeccionReportes.TabIndex = 1000;
            this.btnSeccionReportes.Text = "Reportes";
            this.btnSeccionReportes.Click += new System.EventHandler(this.btnSeccionReportes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(154, 615);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 995;
            this.label5.Text = "Grupo 6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(154, 597);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 996;
            this.label4.Text = "Desarrollo Por";
            // 
            // barraTitulo
            // 
            this.barraTitulo.Controls.Add(this.tabVentasPorVendedor);
            this.barraTitulo.Controls.Add(this.tabVentas);
            this.barraTitulo.Controls.Add(this.tabAgregarCliente);
            this.barraTitulo.Controls.Add(this.tabBuscarCliente);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Controls.Add(this.pictureBox1);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(250, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.barraTitulo.TabIndex = 1004;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // tabVentasPorVendedor
            // 
            this.tabVentasPorVendedor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabVentasPorVendedor.Checked = true;
            this.tabVentasPorVendedor.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabVentasPorVendedor.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabVentasPorVendedor.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabVentasPorVendedor.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabVentasPorVendedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabVentasPorVendedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabVentasPorVendedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabVentasPorVendedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabVentasPorVendedor.FillColor = System.Drawing.SystemColors.Control;
            this.tabVentasPorVendedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVentasPorVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabVentasPorVendedor.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabVentasPorVendedor.Location = new System.Drawing.Point(557, 0);
            this.tabVentasPorVendedor.Name = "tabVentasPorVendedor";
            this.tabVentasPorVendedor.Size = new System.Drawing.Size(180, 50);
            this.tabVentasPorVendedor.TabIndex = 1011;
            this.tabVentasPorVendedor.Text = "Ventas Por Vendedor";
            this.tabVentasPorVendedor.Visible = false;
            // 
            // tabVentas
            // 
            this.tabVentas.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabVentas.Checked = true;
            this.tabVentas.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabVentas.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabVentas.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabVentas.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabVentas.FillColor = System.Drawing.SystemColors.Control;
            this.tabVentas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabVentas.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabVentas.Location = new System.Drawing.Point(371, 0);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Size = new System.Drawing.Size(180, 50);
            this.tabVentas.TabIndex = 1010;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.Visible = false;
            // 
            // tabAgregarCliente
            // 
            this.tabAgregarCliente.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabAgregarCliente.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabAgregarCliente.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabAgregarCliente.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabAgregarCliente.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabAgregarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabAgregarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabAgregarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabAgregarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabAgregarCliente.FillColor = System.Drawing.SystemColors.Control;
            this.tabAgregarCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabAgregarCliente.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabAgregarCliente.Location = new System.Drawing.Point(371, 0);
            this.tabAgregarCliente.Name = "tabAgregarCliente";
            this.tabAgregarCliente.Size = new System.Drawing.Size(180, 50);
            this.tabAgregarCliente.TabIndex = 1013;
            this.tabAgregarCliente.Text = "Agregar Cliente";
            this.tabAgregarCliente.Click += new System.EventHandler(this.tabAltaClientes_Click);
            // 
            // tabBuscarCliente
            // 
            this.tabBuscarCliente.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabBuscarCliente.Checked = true;
            this.tabBuscarCliente.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabBuscarCliente.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabBuscarCliente.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabBuscarCliente.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabBuscarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabBuscarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabBuscarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabBuscarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabBuscarCliente.FillColor = System.Drawing.SystemColors.Control;
            this.tabBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabBuscarCliente.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabBuscarCliente.Location = new System.Drawing.Point(185, 0);
            this.tabBuscarCliente.Name = "tabBuscarCliente";
            this.tabBuscarCliente.Size = new System.Drawing.Size(180, 50);
            this.tabBuscarCliente.TabIndex = 1012;
            this.tabBuscarCliente.Text = "Buscar Cliente";
            this.tabBuscarCliente.Click += new System.EventHandler(this.tabBuscarCliente_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCerrar.Location = new System.Drawing.Point(1000, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 50);
            this.btnCerrar.TabIndex = 1002;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 995;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 600);
            this.panelContenedor.TabIndex = 1005;
            this.panelContenedor.Click += new System.EventHandler(this.btnSeccionClientes_Click);
            // 
            // MenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 0);
            this.Name = "MenuVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuUsuario";
            this.Load += new System.EventHandler(this.MenuUsuario_Load);
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private Guna.UI2.WinForms.Guna2Button btnSeccionReportes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private Guna.UI2.WinForms.Guna2Button btnSeccionVentas;
        private Guna.UI2.WinForms.Guna2Button tabVentasPorVendedor;
        private Guna.UI2.WinForms.Guna2Button tabVentas;
        private Guna.UI2.WinForms.Guna2Button tabBuscarCliente;
        private Guna.UI2.WinForms.Guna2Button btnSeccionCliente;
        private Guna.UI2.WinForms.Guna2Button tabAgregarCliente;
    }
}