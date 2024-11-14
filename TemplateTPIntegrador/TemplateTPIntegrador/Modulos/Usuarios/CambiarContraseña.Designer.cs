namespace TemplateTPIntegrador.Modulos.Usuarios
{
    partial class CambiarContraseña
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IconoCandado = new System.Windows.Forms.PictureBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_ActualizarPass = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCandado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(146, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 100035;
            this.label1.Text = "Nueva Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(133, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 21);
            this.label2.TabIndex = 100034;
            this.label2.Text = "Por razones de Seguridad por favor ingresar una nueva contraseña ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.IconoCandado);
            this.panel4.Controls.Add(this.txt_contraseña);
            this.panel4.Location = new System.Drawing.Point(150, 206);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 45);
            this.panel4.TabIndex = 100036;
            // 
            // IconoCandado
            // 
            this.IconoCandado.Image = global::TemplateTPIntegrador.Properties.Resources.kissclipart_password_icon_clipart_password_computer_icons_clip_d813f06606bcdc9a;
            this.IconoCandado.Location = new System.Drawing.Point(15, 10);
            this.IconoCandado.Name = "IconoCandado";
            this.IconoCandado.Size = new System.Drawing.Size(24, 24);
            this.IconoCandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoCandado.TabIndex = 3;
            this.IconoCandado.TabStop = false;
            this.IconoCandado.MouseLeave += new System.EventHandler(this.IconoCandado_MouseLeave);
            this.IconoCandado.MouseHover += new System.EventHandler(this.IconoCandado_MouseHover);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.White;
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_contraseña.Location = new System.Drawing.Point(52, 15);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(433, 17);
            this.txt_contraseña.TabIndex = 0;
            this.txt_contraseña.UseSystemPasswordChar = true;
            // 
            // btn_ActualizarPass
            // 
            this.btn_ActualizarPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_ActualizarPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ActualizarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarPass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarPass.ForeColor = System.Drawing.Color.White;
            this.btn_ActualizarPass.Location = new System.Drawing.Point(302, 371);
            this.btn_ActualizarPass.Name = "btn_ActualizarPass";
            this.btn_ActualizarPass.Size = new System.Drawing.Size(195, 35);
            this.btn_ActualizarPass.TabIndex = 100037;
            this.btn_ActualizarPass.Text = "ACTUALIZAR";
            this.btn_ActualizarPass.UseVisualStyleBackColor = false;
            this.btn_ActualizarPass.Click += new System.EventHandler(this.btn_ActualizarPass_Click);
            // 
            // CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ActualizarPass);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarContraseña";
            this.Text = "CambiarContraseña";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCandado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox IconoCandado;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_ActualizarPass;
    }
}