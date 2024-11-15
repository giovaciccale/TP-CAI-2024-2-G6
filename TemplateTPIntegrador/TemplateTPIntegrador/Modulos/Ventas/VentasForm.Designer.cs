﻿namespace TemplateTPIntegrador.Modulos.Ventas
{
    partial class VentasForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.panelFechaNacimiento = new System.Windows.Forms.Panel();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panelSeleccionarCliente = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.cmb_clientes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_cliente = new System.Windows.Forms.Label();
            this.cantidad_int = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stock_int = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmb_productos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.agregarcarrito_btn = new System.Windows.Forms.Button();
            this.finalizar_btn = new System.Windows.Forms.Button();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridViewCarrito = new System.Windows.Forms.DataGridView();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panelFechaNacimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panelSeleccionarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad_int)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(772, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 30);
            this.label6.TabIndex = 1018;
            this.label6.Text = "Nombre :";
            // 
            // panelFechaNacimiento
            // 
            this.panelFechaNacimiento.BackColor = System.Drawing.SystemColors.Control;
            this.panelFechaNacimiento.Controls.Add(this.txt_nombreCliente);
            this.panelFechaNacimiento.Controls.Add(this.pictureBox11);
            this.panelFechaNacimiento.Location = new System.Drawing.Point(778, 89);
            this.panelFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFechaNacimiento.Name = "panelFechaNacimiento";
            this.panelFechaNacimiento.Size = new System.Drawing.Size(734, 69);
            this.panelFechaNacimiento.TabIndex = 1017;
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombreCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_nombreCliente.Location = new System.Drawing.Point(82, 18);
            this.txt_nombreCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.ReadOnly = true;
            this.txt_nombreCliente.Size = new System.Drawing.Size(632, 30);
            this.txt_nombreCliente.TabIndex = 1001;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox11.Location = new System.Drawing.Point(22, 17);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(36, 37);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 1002;
            this.pictureBox11.TabStop = false;
            // 
            // panelSeleccionarCliente
            // 
            this.panelSeleccionarCliente.BackColor = System.Drawing.SystemColors.Window;
            this.panelSeleccionarCliente.Controls.Add(this.pictureBox10);
            this.panelSeleccionarCliente.Controls.Add(this.cmb_clientes);
            this.panelSeleccionarCliente.Location = new System.Drawing.Point(45, 89);
            this.panelSeleccionarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSeleccionarCliente.Name = "panelSeleccionarCliente";
            this.panelSeleccionarCliente.Size = new System.Drawing.Size(735, 69);
            this.panelSeleccionarCliente.TabIndex = 1016;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox10.Location = new System.Drawing.Point(22, 17);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(36, 37);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 1000;
            this.pictureBox10.TabStop = false;
            // 
            // cmb_clientes
            // 
            this.cmb_clientes.BackColor = System.Drawing.Color.Transparent;
            this.cmb_clientes.BorderColor = System.Drawing.Color.White;
            this.cmb_clientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_clientes.DropDownHeight = 150;
            this.cmb_clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_clientes.DropDownWidth = 200;
            this.cmb_clientes.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_clientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cmb_clientes.IntegralHeight = false;
            this.cmb_clientes.ItemHeight = 30;
            this.cmb_clientes.Location = new System.Drawing.Point(82, 8);
            this.cmb_clientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Size = new System.Drawing.Size(622, 36);
            this.cmb_clientes.TabIndex = 0;
            // 
            // txt_cliente
            // 
            this.txt_cliente.AutoSize = true;
            this.txt_cliente.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_cliente.Location = new System.Drawing.Point(39, 52);
            this.txt_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(284, 30);
            this.txt_cliente.TabIndex = 1015;
            this.txt_cliente.Text = "Ingrese DNI de cliente:";
            // 
            // cantidad_int
            // 
            this.cantidad_int.BackColor = System.Drawing.Color.Transparent;
            this.cantidad_int.BorderColor = System.Drawing.Color.White;
            this.cantidad_int.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cantidad_int.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cantidad_int.Location = new System.Drawing.Point(44, 357);
            this.cantidad_int.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cantidad_int.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cantidad_int.Name = "cantidad_int";
            this.cantidad_int.Size = new System.Drawing.Size(736, 69);
            this.cantidad_int.TabIndex = 100006;
            this.cantidad_int.TextOffset = new System.Drawing.Point(235, 0);
            this.cantidad_int.UpDownButtonFillColor = System.Drawing.Color.White;
            this.cantidad_int.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(39, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 30);
            this.label3.TabIndex = 100007;
            this.label3.Text = "Cantidad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(772, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 100011;
            this.label1.Text = "Stock:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.stock_int);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(778, 357);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 69);
            this.panel1.TabIndex = 100010;
            // 
            // stock_int
            // 
            this.stock_int.BackColor = System.Drawing.SystemColors.Control;
            this.stock_int.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stock_int.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_int.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.stock_int.Location = new System.Drawing.Point(82, 18);
            this.stock_int.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stock_int.Name = "stock_int";
            this.stock_int.ReadOnly = true;
            this.stock_int.Size = new System.Drawing.Size(632, 30);
            this.stock_int.TabIndex = 1001;
            this.stock_int.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(22, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1002;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.cmb_productos);
            this.panel2.Location = new System.Drawing.Point(45, 223);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 69);
            this.panel2.TabIndex = 100009;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(22, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1000;
            this.pictureBox2.TabStop = false;
            // 
            // cmb_productos
            // 
            this.cmb_productos.BackColor = System.Drawing.Color.Transparent;
            this.cmb_productos.BorderColor = System.Drawing.Color.White;
            this.cmb_productos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_productos.DropDownHeight = 150;
            this.cmb_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_productos.DropDownWidth = 200;
            this.cmb_productos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_productos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_productos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cmb_productos.IntegralHeight = false;
            this.cmb_productos.ItemHeight = 30;
            this.cmb_productos.Location = new System.Drawing.Point(82, 8);
            this.cmb_productos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_productos.Name = "cmb_productos";
            this.cmb_productos.Size = new System.Drawing.Size(622, 36);
            this.cmb_productos.TabIndex = 0;
            this.cmb_productos.SelectedIndexChanged += new System.EventHandler(this.cmb_productos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(39, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 30);
            this.label2.TabIndex = 100008;
            this.label2.Text = "Seleccione Un Producto :";
            // 
            // agregarcarrito_btn
            // 
            this.agregarcarrito_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.agregarcarrito_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarcarrito_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarcarrito_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarcarrito_btn.ForeColor = System.Drawing.Color.White;
            this.agregarcarrito_btn.Location = new System.Drawing.Point(45, 815);
            this.agregarcarrito_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agregarcarrito_btn.Name = "agregarcarrito_btn";
            this.agregarcarrito_btn.Size = new System.Drawing.Size(315, 54);
            this.agregarcarrito_btn.TabIndex = 100032;
            this.agregarcarrito_btn.Text = "AGREGAR A CARRITO";
            this.agregarcarrito_btn.UseVisualStyleBackColor = false;
            this.agregarcarrito_btn.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // finalizar_btn
            // 
            this.finalizar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.finalizar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finalizar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizar_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizar_btn.ForeColor = System.Drawing.Color.White;
            this.finalizar_btn.Location = new System.Drawing.Point(1197, 815);
            this.finalizar_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finalizar_btn.Name = "finalizar_btn";
            this.finalizar_btn.Size = new System.Drawing.Size(315, 54);
            this.finalizar_btn.TabIndex = 100033;
            this.finalizar_btn.Text = "FINALIZAR COMPRA";
            this.finalizar_btn.UseVisualStyleBackColor = false;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPrecioUnitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(771, 186);
            this.lblPrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(199, 30);
            this.lblPrecioUnitario.TabIndex = 100036;
            this.lblPrecioUnitario.Text = "Precio Unitario :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.txtPrecioUnitario);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(777, 223);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 69);
            this.panel3.TabIndex = 100035;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(82, 18);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(632, 30);
            this.txtPrecioUnitario.TabIndex = 1001;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox3.Location = new System.Drawing.Point(22, 17);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1002;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridViewCarrito
            // 
            this.dataGridViewCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCarrito.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrito.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCarrito.Location = new System.Drawing.Point(44, 455);
            this.dataGridViewCarrito.Name = "dataGridViewCarrito";
            this.dataGridViewCarrito.RowHeadersWidth = 62;
            this.dataGridViewCarrito.Size = new System.Drawing.Size(1467, 271);
            this.dataGridViewCarrito.TabIndex = 100037;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(40, 737);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(174, 20);
            this.lbl_Total.TabIndex = 100038;
            this.lbl_Total.Text = "Total acumulado: $0.00";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(369, 815);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(315, 54);
            this.btnEliminar.TabIndex = 100039;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 923);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.dataGridViewCarrito);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.finalizar_btn);
            this.Controls.Add(this.agregarcarrito_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidad_int);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelFechaNacimiento);
            this.Controls.Add(this.panelSeleccionarCliente);
            this.Controls.Add(this.txt_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentasForm";
            this.Text = "VentasForm";
            this.panelFechaNacimiento.ResumeLayout(false);
            this.panelFechaNacimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panelSeleccionarCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad_int)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelFechaNacimiento;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panelSeleccionarCliente;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label txt_cliente;
        private Guna.UI2.WinForms.Guna2NumericUpDown cantidad_int;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox stock_int;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button agregarcarrito_btn;
        private System.Windows.Forms.Button finalizar_btn;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_clientes;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridViewCarrito;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btnEliminar;
    }
}