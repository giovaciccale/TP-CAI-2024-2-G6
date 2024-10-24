﻿namespace TemplateTPIntegrador
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnSeccionUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.tabEliminarUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.tabModificarUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.tabRegistrarUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnSeccionProductos = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeccionProveedores = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeccionReportes = new Guna.UI2.WinForms.Guna2Button();
            this.menuVertical.SuspendLayout();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.menuVertical.Controls.Add(this.btnSeccionReportes);
            this.menuVertical.Controls.Add(this.btnSeccionProveedores);
            this.menuVertical.Controls.Add(this.btnSeccionProductos);
            this.menuVertical.Controls.Add(this.btnSeccionUsuarios);
            this.menuVertical.Controls.Add(this.label5);
            this.menuVertical.Controls.Add(this.label4);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 650);
            this.menuVertical.TabIndex = 993;
            // 
            // btnSeccionUsuarios
            // 
            this.btnSeccionUsuarios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSeccionUsuarios.Checked = true;
            this.btnSeccionUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeccionUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeccionUsuarios.FillColor = System.Drawing.Color.Empty;
            this.btnSeccionUsuarios.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSeccionUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnSeccionUsuarios.Location = new System.Drawing.Point(0, 125);
            this.btnSeccionUsuarios.Name = "btnSeccionUsuarios";
            this.btnSeccionUsuarios.Size = new System.Drawing.Size(250, 40);
            this.btnSeccionUsuarios.TabIndex = 997;
            this.btnSeccionUsuarios.Text = "Usuarios";
            this.btnSeccionUsuarios.Click += new System.EventHandler(this.btnSeccionUsuarios_Click);
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
            // barraTitulo
            // 
            this.barraTitulo.Controls.Add(this.tabEliminarUsuarios);
            this.barraTitulo.Controls.Add(this.tabModificarUsuarios);
            this.barraTitulo.Controls.Add(this.tabRegistrarUsuarios);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Controls.Add(this.pictureBox1);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(250, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.barraTitulo.TabIndex = 1003;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // tabEliminarUsuarios
            // 
            this.tabEliminarUsuarios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabEliminarUsuarios.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabEliminarUsuarios.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabEliminarUsuarios.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabEliminarUsuarios.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabEliminarUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabEliminarUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabEliminarUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabEliminarUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabEliminarUsuarios.FillColor = System.Drawing.SystemColors.Control;
            this.tabEliminarUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEliminarUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabEliminarUsuarios.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabEliminarUsuarios.Location = new System.Drawing.Point(621, 0);
            this.tabEliminarUsuarios.Name = "tabEliminarUsuarios";
            this.tabEliminarUsuarios.Size = new System.Drawing.Size(180, 50);
            this.tabEliminarUsuarios.TabIndex = 1004;
            this.tabEliminarUsuarios.Text = "Eliminar Usuarios";
            this.tabEliminarUsuarios.Click += new System.EventHandler(this.tabEliminarUsuarios_Click);
            // 
            // tabModificarUsuarios
            // 
            this.tabModificarUsuarios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabModificarUsuarios.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabModificarUsuarios.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabModificarUsuarios.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabModificarUsuarios.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabModificarUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabModificarUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabModificarUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabModificarUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabModificarUsuarios.FillColor = System.Drawing.SystemColors.Control;
            this.tabModificarUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabModificarUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabModificarUsuarios.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabModificarUsuarios.Location = new System.Drawing.Point(435, 0);
            this.tabModificarUsuarios.Name = "tabModificarUsuarios";
            this.tabModificarUsuarios.Size = new System.Drawing.Size(180, 50);
            this.tabModificarUsuarios.TabIndex = 1003;
            this.tabModificarUsuarios.Text = "Modificar Usuarios";
            this.tabModificarUsuarios.Click += new System.EventHandler(this.tabModificarUsuarios_Click);
            // 
            // tabRegistrarUsuarios
            // 
            this.tabRegistrarUsuarios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabRegistrarUsuarios.Checked = true;
            this.tabRegistrarUsuarios.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabRegistrarUsuarios.CheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tabRegistrarUsuarios.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.tabRegistrarUsuarios.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabRegistrarUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabRegistrarUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabRegistrarUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabRegistrarUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabRegistrarUsuarios.FillColor = System.Drawing.SystemColors.Control;
            this.tabRegistrarUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegistrarUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabRegistrarUsuarios.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabRegistrarUsuarios.Location = new System.Drawing.Point(249, 0);
            this.tabRegistrarUsuarios.Name = "tabRegistrarUsuarios";
            this.tabRegistrarUsuarios.Size = new System.Drawing.Size(180, 50);
            this.tabRegistrarUsuarios.TabIndex = 0;
            this.tabRegistrarUsuarios.Text = "Registrar Usuarios";
            this.tabRegistrarUsuarios.Click += new System.EventHandler(this.tabRegistrarUsuarios_Click);
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
            this.panelContenedor.TabIndex = 1004;
            // 
            // btnSeccionProductos
            // 
            this.btnSeccionProductos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSeccionProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeccionProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeccionProductos.FillColor = System.Drawing.Color.Empty;
            this.btnSeccionProductos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSeccionProductos.ForeColor = System.Drawing.Color.White;
            this.btnSeccionProductos.Location = new System.Drawing.Point(0, 171);
            this.btnSeccionProductos.Name = "btnSeccionProductos";
            this.btnSeccionProductos.Size = new System.Drawing.Size(250, 40);
            this.btnSeccionProductos.TabIndex = 998;
            this.btnSeccionProductos.Text = "Productos";
            // 
            // btnSeccionProveedores
            // 
            this.btnSeccionProveedores.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSeccionProveedores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionProveedores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeccionProveedores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeccionProveedores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeccionProveedores.FillColor = System.Drawing.Color.Empty;
            this.btnSeccionProveedores.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSeccionProveedores.ForeColor = System.Drawing.Color.White;
            this.btnSeccionProveedores.Location = new System.Drawing.Point(0, 217);
            this.btnSeccionProveedores.Name = "btnSeccionProveedores";
            this.btnSeccionProveedores.Size = new System.Drawing.Size(250, 40);
            this.btnSeccionProveedores.TabIndex = 999;
            this.btnSeccionProveedores.Text = "Proveedores";
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
            this.btnSeccionReportes.Location = new System.Drawing.Point(0, 263);
            this.btnSeccionReportes.Name = "btnSeccionReportes";
            this.btnSeccionReportes.Size = new System.Drawing.Size(250, 40);
            this.btnSeccionReportes.TabIndex = 1000;
            this.btnSeccionReportes.Text = "Reportes";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(300, 0);
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 0);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button tabRegistrarUsuarios;
        private Guna.UI2.WinForms.Guna2Button tabEliminarUsuarios;
        private Guna.UI2.WinForms.Guna2Button tabModificarUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnSeccionUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnSeccionReportes;
        private Guna.UI2.WinForms.Guna2Button btnSeccionProveedores;
        private Guna.UI2.WinForms.Guna2Button btnSeccionProductos;
    }
}