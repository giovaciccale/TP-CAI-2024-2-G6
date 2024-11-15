namespace TemplateTPIntegrador.Modulos.Reportes
{
    partial class ReporteStockForm
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
            this.cmb_productos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFechaNacimiento = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panelSeleccionarCliente = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agregarcarrito_btn = new System.Windows.Forms.Button();
            this.panelFechaNacimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panelSeleccionarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_productos
            // 
            this.cmb_productos.FormattingEnabled = true;
            this.cmb_productos.Location = new System.Drawing.Point(65, 26);
            this.cmb_productos.Name = "cmb_productos";
            this.cmb_productos.Size = new System.Drawing.Size(1304, 28);
            this.cmb_productos.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(93, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 30);
            this.label6.TabIndex = 1019;
            this.label6.Text = "Nombre Producto:";
            // 
            // panelFechaNacimiento
            // 
            this.panelFechaNacimiento.BackColor = System.Drawing.SystemColors.Control;
            this.panelFechaNacimiento.Controls.Add(this.comboBox1);
            this.panelFechaNacimiento.Controls.Add(this.pictureBox11);
            this.panelFechaNacimiento.Location = new System.Drawing.Point(98, 121);
            this.panelFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFechaNacimiento.Name = "panelFechaNacimiento";
            this.panelFechaNacimiento.Size = new System.Drawing.Size(1402, 69);
            this.panelFechaNacimiento.TabIndex = 1020;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1304, 28);
            this.comboBox1.TabIndex = 1023;
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
            this.panelSeleccionarCliente.Controls.Add(this.cmb_productos);
            this.panelSeleccionarCliente.Location = new System.Drawing.Point(98, 257);
            this.panelSeleccionarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSeleccionarCliente.Name = "panelSeleccionarCliente";
            this.panelSeleccionarCliente.Size = new System.Drawing.Size(1402, 69);
            this.panelSeleccionarCliente.TabIndex = 1021;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(93, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 1022;
            this.label1.Text = "Categoría:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 522);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1402, 230);
            this.dataGridView1.TabIndex = 1023;
            // 
            // agregarcarrito_btn
            // 
            this.agregarcarrito_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.agregarcarrito_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarcarrito_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarcarrito_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarcarrito_btn.ForeColor = System.Drawing.Color.White;
            this.agregarcarrito_btn.Location = new System.Drawing.Point(632, 396);
            this.agregarcarrito_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agregarcarrito_btn.Name = "agregarcarrito_btn";
            this.agregarcarrito_btn.Size = new System.Drawing.Size(315, 54);
            this.agregarcarrito_btn.TabIndex = 100033;
            this.agregarcarrito_btn.Text = "BUSCAR STOCK";
            this.agregarcarrito_btn.UseVisualStyleBackColor = false;
            // 
            // ReporteStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 923);
            this.ControlBox = false;
            this.Controls.Add(this.agregarcarrito_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSeleccionarCliente);
            this.Controls.Add(this.panelFechaNacimiento);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteStockForm";
            this.Text = "ReporteStockForm";
            this.panelFechaNacimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panelSeleccionarCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_productos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelFechaNacimiento;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panelSeleccionarCliente;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button agregarcarrito_btn;
    }
}