using System;

namespace TemplateTPIntegrador.Modulos.Clientes
{
    partial class AltaClientesForm
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
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTelefono = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.panelApellido = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.panelDni = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.panelDireccion = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelNombre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_crearUsuario = new System.Windows.Forms.Button();
            this.panelFechaNacimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panelApellido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelDni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panelNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(32, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 21);
            this.label6.TabIndex = 100016;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // panelFechaNacimiento
            // 
            this.panelFechaNacimiento.BackColor = System.Drawing.SystemColors.Control;
            this.panelFechaNacimiento.Controls.Add(this.txt_fecha);
            this.panelFechaNacimiento.Controls.Add(this.pictureBox11);
            this.panelFechaNacimiento.Location = new System.Drawing.Point(36, 270);
            this.panelFechaNacimiento.Name = "panelFechaNacimiento";
            this.panelFechaNacimiento.Size = new System.Drawing.Size(489, 45);
            this.panelFechaNacimiento.TabIndex = 100005;
            // 
            // txt_fecha
            // 
            this.txt_fecha.CalendarFont = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_fecha.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_fecha.Location = new System.Drawing.Point(55, 11);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(416, 24);
            this.txt_fecha.TabIndex = 0;
            this.txt_fecha.Value = DateTime.Now; // Se ajusta a la fecha actual
            this.txt_fecha.ValueChanged += new System.EventHandler(this.txt_fecha_ValueChanged);
            this.txt_fecha.Enter += new System.EventHandler(this.txt_fecha_ValueChanged);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox11.Location = new System.Drawing.Point(15, 11);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(24, 24);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 1002;
            this.pictureBox11.TabStop = false;
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.Control;
            this.panelEmail.Controls.Add(this.pictureBox6);
            this.panelEmail.Controls.Add(this.txt_email);
            this.panelEmail.Location = new System.Drawing.Point(35, 195);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(490, 45);
            this.panelEmail.TabIndex = 100004;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox6.Location = new System.Drawing.Point(15, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1001;
            this.pictureBox6.TabStop = false;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Control;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_email.Location = new System.Drawing.Point(55, 12);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(416, 20);
            this.txt_email.TabIndex = 0;
            this.txt_email.Click += new System.EventHandler(this.txt_email_TextChanged);
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            this.txt_email.Enter += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(32, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 100014;
            this.label2.Text = "Email :";
            // 
            // panelTelefono
            // 
            this.panelTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.panelTelefono.Controls.Add(this.pictureBox9);
            this.panelTelefono.Controls.Add(this.txt_telefono);
            this.panelTelefono.Location = new System.Drawing.Point(525, 195);
            this.panelTelefono.Name = "panelTelefono";
            this.panelTelefono.Size = new System.Drawing.Size(490, 45);
            this.panelTelefono.TabIndex = 100008;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox9.Location = new System.Drawing.Point(14, 12);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(24, 24);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 1002;
            this.pictureBox9.TabStop = false;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.SystemColors.Control;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_telefono.Location = new System.Drawing.Point(55, 12);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(421, 20);
            this.txt_telefono.TabIndex = 0;
            this.txt_telefono.Click += new System.EventHandler(this.txt_telefono_TextChanged);
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            this.txt_telefono.Enter += new System.EventHandler(this.txt_telefono_TextChanged);
            // 
            // panelApellido
            // 
            this.panelApellido.BackColor = System.Drawing.SystemColors.Control;
            this.panelApellido.Controls.Add(this.pictureBox4);
            this.panelApellido.Controls.Add(this.txt_apellido);
            this.panelApellido.Location = new System.Drawing.Point(35, 120);
            this.panelApellido.Name = "panelApellido";
            this.panelApellido.Size = new System.Drawing.Size(490, 45);
            this.panelApellido.TabIndex = 100003;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox4.Location = new System.Drawing.Point(15, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 998;
            this.pictureBox4.TabStop = false;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.SystemColors.Control;
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_apellido.Location = new System.Drawing.Point(55, 12);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(416, 20);
            this.txt_apellido.TabIndex = 0;
            this.txt_apellido.Click += new System.EventHandler(this.txt_apellido_TextChanged);
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            this.txt_apellido.Enter += new System.EventHandler(this.txt_apellido_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblApellido.Location = new System.Drawing.Point(31, 96);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 21);
            this.lblApellido.TabIndex = 100019;
            this.lblApellido.Text = "Apellido :";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTelefono.Location = new System.Drawing.Point(521, 171);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(84, 21);
            this.lblTelefono.TabIndex = 100013;
            this.lblTelefono.Text = "Teléfono :";
            // 
            // panelDni
            // 
            this.panelDni.BackColor = System.Drawing.SystemColors.Control;
            this.panelDni.Controls.Add(this.pictureBox7);
            this.panelDni.Controls.Add(this.txt_dni);
            this.panelDni.Location = new System.Drawing.Point(525, 45);
            this.panelDni.Name = "panelDni";
            this.panelDni.Size = new System.Drawing.Size(490, 45);
            this.panelDni.TabIndex = 100006;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox7.Location = new System.Drawing.Point(15, 11);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 1000;
            this.pictureBox7.TabStop = false;
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.SystemColors.Control;
            this.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_dni.Location = new System.Drawing.Point(55, 12);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(421, 20);
            this.txt_dni.TabIndex = 0;
            this.txt_dni.Click += new System.EventHandler(this.txt_dni_TextChanged);
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            this.txt_dni.Enter += new System.EventHandler(this.txt_dni_TextChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblDireccion.Location = new System.Drawing.Point(521, 96);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(91, 21);
            this.lblDireccion.TabIndex = 100012;
            this.lblDireccion.Text = "Dirección :";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblDni.Location = new System.Drawing.Point(521, 21);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(47, 21);
            this.lblDni.TabIndex = 100011;
            this.lblDni.Text = "DNI :";
            // 
            // panelDireccion
            // 
            this.panelDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.panelDireccion.Controls.Add(this.pictureBox8);
            this.panelDireccion.Controls.Add(this.txt_direccion);
            this.panelDireccion.Location = new System.Drawing.Point(525, 120);
            this.panelDireccion.Name = "panelDireccion";
            this.panelDireccion.Size = new System.Drawing.Size(490, 45);
            this.panelDireccion.TabIndex = 100007;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox8.Location = new System.Drawing.Point(15, 11);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 24);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 1001;
            this.pictureBox8.TabStop = false;
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.SystemColors.Control;
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_direccion.Location = new System.Drawing.Point(55, 12);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(421, 20);
            this.txt_direccion.TabIndex = 0;
            this.txt_direccion.Click += new System.EventHandler(this.txt_direccion_TextChanged);
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
            this.txt_direccion.Enter += new System.EventHandler(this.txt_direccion_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblNombre.Location = new System.Drawing.Point(28, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 21);
            this.lblNombre.TabIndex = 100018;
            this.lblNombre.Text = "Nombre :";
            // 
            // panelNombre
            // 
            this.panelNombre.BackColor = System.Drawing.Color.White;
            this.panelNombre.Controls.Add(this.pictureBox1);
            this.panelNombre.Controls.Add(this.txt_nombre);
            this.panelNombre.Location = new System.Drawing.Point(35, 45);
            this.panelNombre.Name = "panelNombre";
            this.panelNombre.Size = new System.Drawing.Size(490, 45);
            this.panelNombre.TabIndex = 100002;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 997;
            this.pictureBox1.TabStop = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_nombre.Location = new System.Drawing.Point(55, 12);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(416, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.Click += new System.EventHandler(this.txt_nombre_TextChanged);
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // btn_crearUsuario
            // 
            this.btn_crearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_crearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_crearUsuario.Location = new System.Drawing.Point(451, 540);
            this.btn_crearUsuario.Name = "btn_crearUsuario";
            this.btn_crearUsuario.Size = new System.Drawing.Size(148, 35);
            this.btn_crearUsuario.TabIndex = 100010;
            this.btn_crearUsuario.Text = "CREAR CLIENTE";
            this.btn_crearUsuario.UseVisualStyleBackColor = false;
            this.btn_crearUsuario.Click += new System.EventHandler(this.btn_crearUsuario_Click);
            // 
            // AltaClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelFechaNacimiento);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTelefono);
            this.Controls.Add(this.panelApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.panelDni);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.panelDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.panelNombre);
            this.Controls.Add(this.btn_crearUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaClientesForm";
            this.Text = "AltaClientesFom";
            this.panelFechaNacimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelTelefono.ResumeLayout(false);
            this.panelTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panelApellido.ResumeLayout(false);
            this.panelApellido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelDni.ResumeLayout(false);
            this.panelDni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelDireccion.ResumeLayout(false);
            this.panelDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panelNombre.ResumeLayout(false);
            this.panelNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelFechaNacimiento;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTelefono;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Panel panelApellido;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Panel panelDni;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Panel panelDireccion;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_crearUsuario;
    }
}
