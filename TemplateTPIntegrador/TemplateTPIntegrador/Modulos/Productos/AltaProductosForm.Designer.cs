namespace TemplateTPIntegrador.Usuarios.Aministrador
{
    partial class AltaProductosForm
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
            this.txt_host = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.precio_int = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.precio_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stock_int = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btn_guardarproducto = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.precio_int.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_int)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_host
            // 
            this.txt_host.AutoSize = true;
            this.txt_host.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_host.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_host.Location = new System.Drawing.Point(32, 9);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(153, 21);
            this.txt_host.TabIndex = 1005;
            this.txt_host.Text = "Nombre Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(32, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 10001;
            this.label1.Text = "Categoría :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblApellido.Location = new System.Drawing.Point(31, 159);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(61, 21);
            this.lblApellido.TabIndex = 100001;
            this.lblApellido.Text = "Precio:";
            // 
            // precio_int
            // 
            this.precio_int.BackColor = System.Drawing.SystemColors.Control;
            this.precio_int.Controls.Add(this.pictureBox4);
            this.precio_int.Controls.Add(this.precio_in);
            this.precio_int.Location = new System.Drawing.Point(35, 183);
            this.precio_int.Name = "precio_int";
            this.precio_int.Size = new System.Drawing.Size(976, 45);
            this.precio_int.TabIndex = 2;
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
            // precio_in
            // 
            this.precio_in.BackColor = System.Drawing.SystemColors.Control;
            this.precio_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precio_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.precio_in.Location = new System.Drawing.Point(55, 12);
            this.precio_in.Name = "precio_in";
            this.precio_in.Size = new System.Drawing.Size(416, 20);
            this.precio_in.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(31, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 100005;
            this.label3.Text = "Stock :";
            // 
            // stock_int
            // 
            this.stock_int.BackColor = System.Drawing.Color.Transparent;
            this.stock_int.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stock_int.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stock_int.Location = new System.Drawing.Point(35, 338);
            this.stock_int.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stock_int.Name = "stock_int";
            this.stock_int.Size = new System.Drawing.Size(976, 45);
            this.stock_int.TabIndex = 4;
            this.stock_int.ValueChanged += new System.EventHandler(this.stock_int_ValueChanged);
            // 
            // btn_guardarproducto
            // 
            this.btn_guardarproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_guardarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarproducto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarproducto.ForeColor = System.Drawing.Color.White;
            this.btn_guardarproducto.Location = new System.Drawing.Point(271, 473);
            this.btn_guardarproducto.Name = "btn_guardarproducto";
            this.btn_guardarproducto.Size = new System.Drawing.Size(167, 35);
            this.btn_guardarproducto.TabIndex = 5;
            this.btn_guardarproducto.Text = "GUARDAR PRODUCTO";
            this.btn_guardarproducto.UseVisualStyleBackColor = false;
            this.btn_guardarproducto.Click += new System.EventHandler(this.btn_guardarproducto_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.cmbcategoria);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(35, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 45);
            this.panel3.TabIndex = 1;
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbcategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbcategoria.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.ItemHeight = 17;
            this.cmbcategoria.Location = new System.Drawing.Point(55, 15);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(901, 25);
            this.cmbcategoria.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox3.Location = new System.Drawing.Point(15, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 998;
            this.pictureBox3.TabStop = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(523, 473);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(167, 35);
            this.btnlimpiar.TabIndex = 6;
            this.btnlimpiar.Text = "LIMPIAR CAMPOS";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // nombre_txt
            // 
            this.nombre_txt.BackColor = System.Drawing.SystemColors.Control;
            this.nombre_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre_txt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.nombre_txt.Location = new System.Drawing.Point(55, 12);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(416, 20);
            this.nombre_txt.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nombre_txt);
            this.panel1.Location = new System.Drawing.Point(36, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 45);
            this.panel1.TabIndex = 999;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TemplateTPIntegrador.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 998;
            this.pictureBox1.TabStop = false;
            // 
            // AltaProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_guardarproducto);
            this.Controls.Add(this.stock_int);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.precio_int);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_host);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaProductosForm";
            this.Text = "AltaProductosForm";
            this.precio_int.ResumeLayout(false);
            this.precio_int.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_int)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_host;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel precio_int;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox precio_in;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown stock_int;
        private System.Windows.Forms.Button btn_guardarproducto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}