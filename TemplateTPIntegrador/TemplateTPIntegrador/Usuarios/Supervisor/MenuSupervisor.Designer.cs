namespace TemplateTPIntegrador
{
    partial class MenuSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSupervisor));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnSeccionDevoluciones = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeccionReportes = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeccionProductos = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.tabReporteVentasxVendedor = new Guna.UI2.WinForms.Guna2Button();
            this.tabStockCritico = new Guna.UI2.WinForms.Guna2Button();
            this.tabDevoluciones = new Guna.UI2.WinForms.Guna2Button();
            this.tabBajaProductos = new Guna.UI2.WinForms.Guna2Button();
            this.tabModificarProductos = new Guna.UI2.WinForms.Guna2Button();
            this.tabAltaProductos = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tabProductosMasVendidos = new Guna.UI2.WinForms.Guna2Button();
            this.menuVertical.SuspendLayout();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.menuVertical.Controls.Add(this.btnSeccionDevoluciones);
            this.menuVertical.Controls.Add(this.btnSeccionReportes);
            this.menuVertical.Controls.Add(this.btnSeccionProductos);
            this.menuVertical.Controls.Add(this.label5);
            this.menuVertical.Controls.Add(this.label4);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 650);
            this.menuVertical.TabIndex = 994;
            // 
            // btnSeccionDevoluciones
            // 
            this.btnSeccionDevoluciones.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSeccionDevoluciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionDevoluciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionDevoluciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeccionDevoluciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeccionDevoluciones.FillColor = System.Drawing.Color.Empty;
            this.btnSeccionDevoluciones.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSeccionDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btnSeccionDevoluciones.Location = new System.Drawing.Point(0, 171);
            this.btnSeccionDevoluciones.Name = "btnSeccionDevoluciones";
            this.btnSeccionDevoluciones.Size = new System.Drawing.Size(250, 40);
            this.btnSeccionDevoluciones.TabIndex = 1001;
            this.btnSeccionDevoluciones.Text = "Devoluciones";
            this.btnSeccionDevoluciones.Click += new System.EventHandler(this.btnSeccionDevoluciones_Click);
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
            // btnSeccionProductos
            // 
            this.btnSeccionProductos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSeccionProductos.Checked = true;
            this.btnSeccionProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeccionProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeccionProductos.FillColor = System.Drawing.Color.Empty;
            this.btnSeccionProductos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSeccionProductos.ForeColor = System.Drawing.Color.White;
            this.btnSeccionProductos.Location = new System.Drawing.Point(0, 125);
            this.btnSeccionProductos.Name = "btnSeccionProductos";
            this.btnSeccionProductos.Size = new System.Drawing.Size(250, 40);
            this.btnSeccionProductos.TabIndex = 998;
            this.btnSeccionProductos.Text = "Productos";
            this.btnSeccionProductos.Click += new System.EventHandler(this.btnSeccionProductos_Click);
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
            this.barraTitulo.Controls.Add(this.tabProductosMasVendidos);
            this.barraTitulo.Controls.Add(this.tabBajaProductos);
            this.barraTitulo.Controls.Add(this.tabReporteVentasxVendedor);
            this.barraTitulo.Controls.Add(this.tabStockCritico);
            this.barraTitulo.Controls.Add(this.tabDevoluciones);
            this.barraTitulo.Controls.Add(this.tabModificarProductos);
            this.barraTitulo.Controls.Add(this.tabAltaProductos);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Controls.Add(this.pictureBox1);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(250, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.barraTitulo.TabIndex = 1004;
            // 
            // tabReporteVentasxVendedor
            // 
            this.tabReporteVentasxVendedor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabReporteVentasxVendedor.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabReporteVentasxVendedor.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabReporteVentasxVendedor.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabReporteVentasxVendedor.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabReporteVentasxVendedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabReporteVentasxVendedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabReporteVentasxVendedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabReporteVentasxVendedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabReporteVentasxVendedor.FillColor = System.Drawing.SystemColors.Control;
            this.tabReporteVentasxVendedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReporteVentasxVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabReporteVentasxVendedor.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabReporteVentasxVendedor.Location = new System.Drawing.Point(435, 0);
            this.tabReporteVentasxVendedor.Name = "tabReporteVentasxVendedor";
            this.tabReporteVentasxVendedor.Size = new System.Drawing.Size(180, 50);
            this.tabReporteVentasxVendedor.TabIndex = 1010;
            this.tabReporteVentasxVendedor.Text = "Ventas Por Vendedor";
            this.tabReporteVentasxVendedor.Visible = false;
            // 
            // tabStockCritico
            // 
            this.tabStockCritico.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabStockCritico.Checked = true;
            this.tabStockCritico.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabStockCritico.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabStockCritico.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabStockCritico.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabStockCritico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabStockCritico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabStockCritico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabStockCritico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabStockCritico.FillColor = System.Drawing.SystemColors.Control;
            this.tabStockCritico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStockCritico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabStockCritico.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabStockCritico.Location = new System.Drawing.Point(249, 0);
            this.tabStockCritico.Name = "tabStockCritico";
            this.tabStockCritico.Size = new System.Drawing.Size(180, 50);
            this.tabStockCritico.TabIndex = 1009;
            this.tabStockCritico.Text = "Stock Crítico";
            this.tabStockCritico.Visible = false;
            // 
            // tabDevoluciones
            // 
            this.tabDevoluciones.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabDevoluciones.Checked = true;
            this.tabDevoluciones.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabDevoluciones.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabDevoluciones.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabDevoluciones.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabDevoluciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabDevoluciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabDevoluciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabDevoluciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabDevoluciones.FillColor = System.Drawing.SystemColors.Control;
            this.tabDevoluciones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDevoluciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabDevoluciones.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabDevoluciones.Location = new System.Drawing.Point(435, 0);
            this.tabDevoluciones.Name = "tabDevoluciones";
            this.tabDevoluciones.Size = new System.Drawing.Size(180, 50);
            this.tabDevoluciones.TabIndex = 1008;
            this.tabDevoluciones.Text = "Devoluciones";
            this.tabDevoluciones.Visible = false;
            // 
            // tabBajaProductos
            // 
            this.tabBajaProductos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabBajaProductos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabBajaProductos.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabBajaProductos.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabBajaProductos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabBajaProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabBajaProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabBajaProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabBajaProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabBajaProductos.FillColor = System.Drawing.SystemColors.Control;
            this.tabBajaProductos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBajaProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabBajaProductos.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabBajaProductos.Location = new System.Drawing.Point(621, 0);
            this.tabBajaProductos.Name = "tabBajaProductos";
            this.tabBajaProductos.Size = new System.Drawing.Size(180, 50);
            this.tabBajaProductos.TabIndex = 1007;
            this.tabBajaProductos.Text = "Baja Productos";
            this.tabBajaProductos.Click += new System.EventHandler(this.tabBajaProductos_Click);
            // 
            // tabModificarProductos
            // 
            this.tabModificarProductos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabModificarProductos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabModificarProductos.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabModificarProductos.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabModificarProductos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabModificarProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabModificarProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabModificarProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabModificarProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabModificarProductos.FillColor = System.Drawing.SystemColors.Control;
            this.tabModificarProductos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabModificarProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabModificarProductos.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabModificarProductos.Location = new System.Drawing.Point(435, 0);
            this.tabModificarProductos.Name = "tabModificarProductos";
            this.tabModificarProductos.Size = new System.Drawing.Size(180, 50);
            this.tabModificarProductos.TabIndex = 1006;
            this.tabModificarProductos.Text = "Modificar Productos";
            this.tabModificarProductos.Click += new System.EventHandler(this.tabModificarProductos_Click);
            // 
            // tabAltaProductos
            // 
            this.tabAltaProductos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabAltaProductos.Checked = true;
            this.tabAltaProductos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabAltaProductos.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabAltaProductos.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabAltaProductos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabAltaProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabAltaProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabAltaProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabAltaProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabAltaProductos.FillColor = System.Drawing.SystemColors.Control;
            this.tabAltaProductos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAltaProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabAltaProductos.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabAltaProductos.Location = new System.Drawing.Point(249, 0);
            this.tabAltaProductos.Name = "tabAltaProductos";
            this.tabAltaProductos.Size = new System.Drawing.Size(180, 50);
            this.tabAltaProductos.TabIndex = 1005;
            this.tabAltaProductos.Text = "Alta Productos";
            this.tabAltaProductos.Click += new System.EventHandler(this.tabAltaProductos_Click);
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
            // 
            // tabProductosMasVendidos
            // 
            this.tabProductosMasVendidos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabProductosMasVendidos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabProductosMasVendidos.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabProductosMasVendidos.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabProductosMasVendidos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabProductosMasVendidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabProductosMasVendidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabProductosMasVendidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabProductosMasVendidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabProductosMasVendidos.FillColor = System.Drawing.SystemColors.Control;
            this.tabProductosMasVendidos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProductosMasVendidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabProductosMasVendidos.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabProductosMasVendidos.Location = new System.Drawing.Point(621, 0);
            this.tabProductosMasVendidos.Name = "tabProductosMasVendidos";
            this.tabProductosMasVendidos.Size = new System.Drawing.Size(180, 50);
            this.tabProductosMasVendidos.TabIndex = 1011;
            this.tabProductosMasVendidos.Text = "Productos Más Vendidos";
            this.tabProductosMasVendidos.Visible = false;
            // 
            // MenuSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 0);
            this.Name = "MenuSupervisor";
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
        private Guna.UI2.WinForms.Guna2Button btnSeccionProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel barraTitulo;
        private Guna.UI2.WinForms.Guna2Button tabBajaProductos;
        private Guna.UI2.WinForms.Guna2Button tabModificarProductos;
        private Guna.UI2.WinForms.Guna2Button tabAltaProductos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private Guna.UI2.WinForms.Guna2Button btnSeccionDevoluciones;
        private Guna.UI2.WinForms.Guna2Button tabDevoluciones;
        private Guna.UI2.WinForms.Guna2Button tabReporteVentasxVendedor;
        private Guna.UI2.WinForms.Guna2Button tabStockCritico;
        private Guna.UI2.WinForms.Guna2Button tabProductosMasVendidos;
    }
}