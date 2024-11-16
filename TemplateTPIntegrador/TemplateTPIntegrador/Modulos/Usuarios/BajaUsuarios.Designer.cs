namespace TemplateTPIntegrador
{
    partial class BajaUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_desactivarUsuario = new System.Windows.Forms.Button();
            this.panelSeleccionarCliente = new System.Windows.Forms.Panel();
            this.cmb_usuarios = new System.Windows.Forms.ComboBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panelSeleccionarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(276, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 100028;
            this.label1.Text = "Elija Usuario a Desactivar :";
            // 
            // btn_desactivarUsuario
            // 
            this.btn_desactivarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_desactivarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_desactivarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desactivarUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desactivarUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_desactivarUsuario.Location = new System.Drawing.Point(428, 540);
            this.btn_desactivarUsuario.Name = "btn_desactivarUsuario";
            this.btn_desactivarUsuario.Size = new System.Drawing.Size(195, 35);
            this.btn_desactivarUsuario.TabIndex = 100030;
            this.btn_desactivarUsuario.Text = "DESACTIVAR USUARIO";
            this.btn_desactivarUsuario.UseVisualStyleBackColor = false;
            this.btn_desactivarUsuario.Click += new System.EventHandler(this.btn_desactivarUsuario_Click);
            // 
            // panelSeleccionarCliente
            // 
            this.panelSeleccionarCliente.BackColor = System.Drawing.SystemColors.Window;
            this.panelSeleccionarCliente.Controls.Add(this.cmb_usuarios);
            this.panelSeleccionarCliente.Controls.Add(this.pictureBox10);
            this.panelSeleccionarCliente.Location = new System.Drawing.Point(280, 127);
            this.panelSeleccionarCliente.Name = "panelSeleccionarCliente";
            this.panelSeleccionarCliente.Size = new System.Drawing.Size(490, 45);
            this.panelSeleccionarCliente.TabIndex = 100032;
            // 
            // cmb_usuarios
            // 
            this.cmb_usuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_usuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_usuarios.DropDownHeight = 30;
            this.cmb_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_usuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_usuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cmb_usuarios.FormattingEnabled = true;
            this.cmb_usuarios.IntegralHeight = false;
            this.cmb_usuarios.Location = new System.Drawing.Point(44, 9);
            this.cmb_usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_usuarios.Name = "cmb_usuarios";
            this.cmb_usuarios.Size = new System.Drawing.Size(427, 29);
            this.cmb_usuarios.TabIndex = 100040;
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
            // BajaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.panelSeleccionarCliente);
            this.Controls.Add(this.btn_desactivarUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BajaUsuarios";
            this.Text = "BajaUsuarios";
            this.panelSeleccionarCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_desactivarUsuario;
        private System.Windows.Forms.Panel panelSeleccionarCliente;
        private System.Windows.Forms.ComboBox cmb_usuarios;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}