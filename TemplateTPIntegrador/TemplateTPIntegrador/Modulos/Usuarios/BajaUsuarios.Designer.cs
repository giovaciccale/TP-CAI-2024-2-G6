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
            this.btn_crearUsuario = new System.Windows.Forms.Button();
            this.cmb_usuarios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(29, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 100028;
            this.label1.Text = "Elija Usuario a Desactivar :";
            // 
            // btn_crearUsuario
            // 
            this.btn_crearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_crearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_crearUsuario.Location = new System.Drawing.Point(378, 255);
            this.btn_crearUsuario.Name = "btn_crearUsuario";
            this.btn_crearUsuario.Size = new System.Drawing.Size(195, 35);
            this.btn_crearUsuario.TabIndex = 100030;
            this.btn_crearUsuario.Text = "DESACTIVAR USUARIO";
            this.btn_crearUsuario.UseVisualStyleBackColor = false;
            this.btn_crearUsuario.Click += new System.EventHandler(this.btn_desactivarUsuario_Click);
            // 
            // cmb_usuarios
            // 
            this.cmb_usuarios.DropDownHeight = 500;
            this.cmb_usuarios.DropDownWidth = 500;
            this.cmb_usuarios.FormattingEnabled = true;
            this.cmb_usuarios.IntegralHeight = false;
            this.cmb_usuarios.Location = new System.Drawing.Point(33, 145);
            this.cmb_usuarios.Name = "cmb_usuarios";
            this.cmb_usuarios.Size = new System.Drawing.Size(459, 21);
            this.cmb_usuarios.TabIndex = 100031;
            // 
            // BajaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.cmb_usuarios);
            this.Controls.Add(this.btn_crearUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BajaUsuarios";
            this.Text = "BajaUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_crearUsuario;
        private System.Windows.Forms.ComboBox cmb_usuarios;
    }
}