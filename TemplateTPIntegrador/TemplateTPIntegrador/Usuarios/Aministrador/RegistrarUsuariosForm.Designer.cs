using System.Resources;
using TemplateTPIntegrador.Properties;

namespace TemplateTPIntegrador
{
    partial class RegistrarUsuariosForm
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
            this.panelNombre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.panelApellido = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lblNumeroRegistro = new System.Windows.Forms.Label();
            this.panelNumeroRegistro = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txt_numeroRegistro = new System.Windows.Forms.TextBox();
            this.panelContraseña = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_contraseñaAlta = new System.Windows.Forms.TextBox();
            this.panelCrearCuenta = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelNombreUsuario = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTipoUsuario = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.panelTelefono = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.panelDni = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.panelDireccion = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lblAltaContraseña = new System.Windows.Forms.Label();
            this.btn_crearUsuario = new System.Windows.Forms.Button();
            this.panelNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelApellido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelNumeroRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelCrearCuenta.SuspendLayout();
            this.panelNombreUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelTipoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panelTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panelDni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNombre
            // 
            this.panelNombre.BackColor = System.Drawing.SystemColors.Control;
            this.panelNombre.Controls.Add(this.pictureBox1);
            this.panelNombre.Controls.Add(this.txt_nombre);
            this.panelNombre.Location = new System.Drawing.Point(35, 138);
            this.panelNombre.Name = "panelNombre";
            this.panelNombre.Size = new System.Drawing.Size(490, 45);
            this.panelNombre.TabIndex = 1;
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
            this.txt_nombre.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_nombre.Location = new System.Drawing.Point(55, 12);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(416, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.Click += new System.EventHandler(this.txt_nombre_Click);
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_Click);
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombre_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblNombre.Location = new System.Drawing.Point(32, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 21);
            this.lblNombre.TabIndex = 10000;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblApellido.Location = new System.Drawing.Point(32, 199);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 21);
            this.lblApellido.TabIndex = 100000;
            this.lblApellido.Text = "Apellido :";
            // 
            // panelApellido
            // 
            this.panelApellido.BackColor = System.Drawing.SystemColors.Control;
            this.panelApellido.Controls.Add(this.pictureBox4);
            this.panelApellido.Controls.Add(this.txt_apellido);
            this.panelApellido.Location = new System.Drawing.Point(35, 223);
            this.panelApellido.Name = "panelApellido";
            this.panelApellido.Size = new System.Drawing.Size(490, 45);
            this.panelApellido.TabIndex = 2;
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
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_Click);
            this.txt_apellido.Enter += new System.EventHandler(this.txt_apellido_Click);
            // 
            // lblNumeroRegistro
            // 
            this.lblNumeroRegistro.AutoSize = true;
            this.lblNumeroRegistro.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNumeroRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblNumeroRegistro.Location = new System.Drawing.Point(521, 29);
            this.lblNumeroRegistro.Name = "lblNumeroRegistro";
            this.lblNumeroRegistro.Size = new System.Drawing.Size(171, 21);
            this.lblNumeroRegistro.TabIndex = 1062;
            this.lblNumeroRegistro.Text = "Número de Registro :";
            // 
            // panelNumeroRegistro
            // 
            this.panelNumeroRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.panelNumeroRegistro.Controls.Add(this.pictureBox5);
            this.panelNumeroRegistro.Controls.Add(this.txt_numeroRegistro);
            this.panelNumeroRegistro.Location = new System.Drawing.Point(525, 53);
            this.panelNumeroRegistro.Name = "panelNumeroRegistro";
            this.panelNumeroRegistro.Size = new System.Drawing.Size(490, 45);
            this.panelNumeroRegistro.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox5.Location = new System.Drawing.Point(15, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 999;
            this.pictureBox5.TabStop = false;
            // 
            // txt_numeroRegistro
            // 
            this.txt_numeroRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.txt_numeroRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_numeroRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_numeroRegistro.Location = new System.Drawing.Point(55, 12);
            this.txt_numeroRegistro.Name = "txt_numeroRegistro";
            this.txt_numeroRegistro.Size = new System.Drawing.Size(421, 20);
            this.txt_numeroRegistro.TabIndex = 0;
            this.txt_numeroRegistro.Click += new System.EventHandler(this.txt_numeroRegistro_TextChanged);
            this.txt_numeroRegistro.TextChanged += new System.EventHandler(this.txt_numeroRegistro_TextChanged);
            this.txt_numeroRegistro.Enter += new System.EventHandler(this.txt_numeroRegistro_TextChanged);
            // 
            // panelContraseña
            // 
            this.panelContraseña.BackColor = System.Drawing.SystemColors.Control;
            this.panelContraseña.Controls.Add(this.pictureBox2);
            this.panelContraseña.Controls.Add(this.txt_contraseñaAlta);
            this.panelContraseña.Location = new System.Drawing.Point(36, 471);
            this.panelContraseña.Name = "panelContraseña";
            this.panelContraseña.Size = new System.Drawing.Size(979, 45);
            this.panelContraseña.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TemplateTPIntegrador.Properties.Resources.kissclipart_password_icon_clipart_password_computer_icons_clip_d813f06606bcdc9a;
            this.pictureBox2.Location = new System.Drawing.Point(15, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1000;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // txt_contraseñaAlta
            // 
            this.txt_contraseñaAlta.BackColor = System.Drawing.SystemColors.Control;
            this.txt_contraseñaAlta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseñaAlta.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_contraseñaAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_contraseñaAlta.Location = new System.Drawing.Point(55, 14);
            this.txt_contraseñaAlta.Name = "txt_contraseñaAlta";
            this.txt_contraseñaAlta.Size = new System.Drawing.Size(910, 17);
            this.txt_contraseñaAlta.TabIndex = 0;
            this.txt_contraseñaAlta.UseSystemPasswordChar = true;
            this.txt_contraseñaAlta.Click += new System.EventHandler(this.txt_contraseñaAlta_Click);
            this.txt_contraseñaAlta.TextChanged += new System.EventHandler(this.txt_contraseñaAlta_Click);
            this.txt_contraseñaAlta.Enter += new System.EventHandler(this.txt_contraseñaAlta_Click);
            // 
            // panelCrearCuenta
            // 
            this.panelCrearCuenta.Controls.Add(this.label6);
            this.panelCrearCuenta.Controls.Add(this.panelNombreUsuario);
            this.panelCrearCuenta.Controls.Add(this.panelEmail);
            this.panelCrearCuenta.Controls.Add(this.label2);
            this.panelCrearCuenta.Controls.Add(this.label1);
            this.panelCrearCuenta.Controls.Add(this.panelTipoUsuario);
            this.panelCrearCuenta.Controls.Add(this.panelTelefono);
            this.panelCrearCuenta.Controls.Add(this.panelApellido);
            this.panelCrearCuenta.Controls.Add(this.lblApellido);
            this.panelCrearCuenta.Controls.Add(this.lblTelefono);
            this.panelCrearCuenta.Controls.Add(this.panelDni);
            this.panelCrearCuenta.Controls.Add(this.lblDireccion);
            this.panelCrearCuenta.Controls.Add(this.lblDni);
            this.panelCrearCuenta.Controls.Add(this.panelDireccion);
            this.panelCrearCuenta.Controls.Add(this.lblAltaContraseña);
            this.panelCrearCuenta.Controls.Add(this.lblNumeroRegistro);
            this.panelCrearCuenta.Controls.Add(this.panelNumeroRegistro);
            this.panelCrearCuenta.Controls.Add(this.lblNombre);
            this.panelCrearCuenta.Controls.Add(this.panelContraseña);
            this.panelCrearCuenta.Controls.Add(this.panelNombre);
            this.panelCrearCuenta.Controls.Add(this.btn_crearUsuario);
            this.panelCrearCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrearCuenta.Location = new System.Drawing.Point(0, 0);
            this.panelCrearCuenta.Name = "panelCrearCuenta";
            this.panelCrearCuenta.Size = new System.Drawing.Size(1050, 600);
            this.panelCrearCuenta.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(32, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 21);
            this.label6.TabIndex = 1006;
            this.label6.Text = "Nombre de Usuario :";
            // 
            // panelNombreUsuario
            // 
            this.panelNombreUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.panelNombreUsuario.Controls.Add(this.pictureBox11);
            this.panelNombreUsuario.Controls.Add(this.txt_nombreUsuario);
            this.panelNombreUsuario.Location = new System.Drawing.Point(36, 394);
            this.panelNombreUsuario.Name = "panelNombreUsuario";
            this.panelNombreUsuario.Size = new System.Drawing.Size(979, 45);
            this.panelNombreUsuario.TabIndex = 8;
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
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombreUsuario.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_nombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_nombreUsuario.Location = new System.Drawing.Point(55, 14);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(910, 17);
            this.txt_nombreUsuario.TabIndex = 0;
            this.txt_nombreUsuario.Click += new System.EventHandler(this.txt_nombreUsuario_TextChanged);
            this.txt_nombreUsuario.TextChanged += new System.EventHandler(this.txt_nombreUsuario_TextChanged);
            this.txt_nombreUsuario.Enter += new System.EventHandler(this.txt_nombreUsuario_TextChanged);
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.Control;
            this.panelEmail.Controls.Add(this.pictureBox6);
            this.panelEmail.Controls.Add(this.txt_email);
            this.panelEmail.Location = new System.Drawing.Point(35, 311);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(490, 45);
            this.panelEmail.TabIndex = 3;
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
            this.label2.Location = new System.Drawing.Point(32, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 1004;
            this.label2.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 1004;
            this.label1.Text = "Tipo De Usuario :";
            // 
            // panelTipoUsuario
            // 
            this.panelTipoUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.panelTipoUsuario.Controls.Add(this.pictureBox10);
            this.panelTipoUsuario.Controls.Add(this.comboBoxTipoUsuario);
            this.panelTipoUsuario.Location = new System.Drawing.Point(35, 53);
            this.panelTipoUsuario.Name = "panelTipoUsuario";
            this.panelTipoUsuario.Size = new System.Drawing.Size(490, 45);
            this.panelTipoUsuario.TabIndex = 0;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox10.Location = new System.Drawing.Point(15, 11);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(24, 24);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 1000;
            this.pictureBox10.TabStop = false;
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTipoUsuario.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.ItemHeight = 17;
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(55, 10);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(416, 25);
            this.comboBoxTipoUsuario.TabIndex = 0;
            this.comboBoxTipoUsuario.Click += new System.EventHandler(this.comboBoxTipoUsuario_Click);
            this.comboBoxTipoUsuario.Enter += new System.EventHandler(this.comboBoxTipoUsuario_Click);
            // 
            // panelTelefono
            // 
            this.panelTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.panelTelefono.Controls.Add(this.pictureBox9);
            this.panelTelefono.Controls.Add(this.txt_telefono);
            this.panelTelefono.Location = new System.Drawing.Point(525, 311);
            this.panelTelefono.Name = "panelTelefono";
            this.panelTelefono.Size = new System.Drawing.Size(490, 45);
            this.panelTelefono.TabIndex = 7;
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
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTelefono.Location = new System.Drawing.Point(521, 287);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(84, 21);
            this.lblTelefono.TabIndex = 1002;
            this.lblTelefono.Text = "Teléfono :";
            // 
            // panelDni
            // 
            this.panelDni.BackColor = System.Drawing.SystemColors.Control;
            this.panelDni.Controls.Add(this.pictureBox7);
            this.panelDni.Controls.Add(this.txt_dni);
            this.panelDni.Location = new System.Drawing.Point(525, 138);
            this.panelDni.Name = "panelDni";
            this.panelDni.Size = new System.Drawing.Size(490, 45);
            this.panelDni.TabIndex = 5;
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
            this.lblDireccion.Location = new System.Drawing.Point(521, 199);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(91, 21);
            this.lblDireccion.TabIndex = 1001;
            this.lblDireccion.Text = "Dirección :";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblDni.Location = new System.Drawing.Point(521, 114);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(47, 21);
            this.lblDni.TabIndex = 1000;
            this.lblDni.Text = "DNI :";
            // 
            // panelDireccion
            // 
            this.panelDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.panelDireccion.Controls.Add(this.pictureBox8);
            this.panelDireccion.Controls.Add(this.txt_direccion);
            this.panelDireccion.Location = new System.Drawing.Point(525, 223);
            this.panelDireccion.Name = "panelDireccion";
            this.panelDireccion.Size = new System.Drawing.Size(490, 45);
            this.panelDireccion.TabIndex = 6;
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
            // lblAltaContraseña
            // 
            this.lblAltaContraseña.AutoSize = true;
            this.lblAltaContraseña.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblAltaContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblAltaContraseña.Location = new System.Drawing.Point(32, 447);
            this.lblAltaContraseña.Name = "lblAltaContraseña";
            this.lblAltaContraseña.Size = new System.Drawing.Size(111, 21);
            this.lblAltaContraseña.TabIndex = 15616;
            this.lblAltaContraseña.Text = "Contraseña :";
            // 
            // btn_crearUsuario
            // 
            this.btn_crearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_crearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_crearUsuario.Location = new System.Drawing.Point(451, 539);
            this.btn_crearUsuario.Name = "btn_crearUsuario";
            this.btn_crearUsuario.Size = new System.Drawing.Size(148, 35);
            this.btn_crearUsuario.TabIndex = 10;
            this.btn_crearUsuario.Text = "CREAR USUARIO";
            this.btn_crearUsuario.UseVisualStyleBackColor = false;
            this.btn_crearUsuario.Click += new System.EventHandler(this.btn_crearUsuario_Click);
            // 
            // RegistrarUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.panelCrearCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarUsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaUsuariosForm";
            this.panelNombre.ResumeLayout(false);
            this.panelNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelApellido.ResumeLayout(false);
            this.panelApellido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelNumeroRegistro.ResumeLayout(false);
            this.panelNumeroRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelContraseña.ResumeLayout(false);
            this.panelContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelCrearCuenta.ResumeLayout(false);
            this.panelCrearCuenta.PerformLayout();
            this.panelNombreUsuario.ResumeLayout(false);
            this.panelNombreUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelTipoUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panelTelefono.ResumeLayout(false);
            this.panelTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panelDni.ResumeLayout(false);
            this.panelDni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelDireccion.ResumeLayout(false);
            this.panelDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Panel panelContraseña;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_contraseñaAlta;
        private System.Windows.Forms.Button btn_crearUsuario;
        private System.Windows.Forms.Panel panelCrearCuenta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel panelApellido;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lblAltaContraseña;
        private System.Windows.Forms.Label lblNumeroRegistro;
        private System.Windows.Forms.Panel panelNumeroRegistro;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txt_numeroRegistro;
        private System.Windows.Forms.Panel panelDni;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Panel panelTelefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Panel panelDireccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTipoUsuario;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelNombreUsuario;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}