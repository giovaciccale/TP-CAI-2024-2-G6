namespace TemplateTPIntegrador.Modulos.Proveedores
{
    partial class BajaProveedores
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
            this.btn_desactivarProveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSeleccionarCliente = new System.Windows.Forms.Panel();
            this.cmb_proveedores = new System.Windows.Forms.ComboBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panelSeleccionarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_desactivarProveedor
            // 
            this.btn_desactivarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_desactivarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_desactivarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desactivarProveedor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desactivarProveedor.ForeColor = System.Drawing.Color.White;
            this.btn_desactivarProveedor.Location = new System.Drawing.Point(606, 352);
            this.btn_desactivarProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_desactivarProveedor.Name = "btn_desactivarProveedor";
            this.btn_desactivarProveedor.Size = new System.Drawing.Size(292, 54);
            this.btn_desactivarProveedor.TabIndex = 100033;
            this.btn_desactivarProveedor.Text = "DESACTIVAR PROVEEDOR";
            this.btn_desactivarProveedor.UseVisualStyleBackColor = false;
            this.btn_desactivarProveedor.Click += new System.EventHandler(this.btn_desactivarProveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(82, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 30);
            this.label1.TabIndex = 100032;
            this.label1.Text = "Elija Proveedor a Desactivar :";
            // 
            // panelSeleccionarCliente
            // 
            this.panelSeleccionarCliente.BackColor = System.Drawing.SystemColors.Window;
            this.panelSeleccionarCliente.Controls.Add(this.cmb_proveedores);
            this.panelSeleccionarCliente.Controls.Add(this.pictureBox10);
            this.panelSeleccionarCliente.Location = new System.Drawing.Point(87, 150);
            this.panelSeleccionarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSeleccionarCliente.Name = "panelSeleccionarCliente";
            this.panelSeleccionarCliente.Size = new System.Drawing.Size(735, 69);
            this.panelSeleccionarCliente.TabIndex = 100034;
            // 
            // cmb_proveedores
            // 
            this.cmb_proveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_proveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_proveedores.DropDownHeight = 30;
            this.cmb_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_proveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_proveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cmb_proveedores.FormattingEnabled = true;
            this.cmb_proveedores.IntegralHeight = false;
            this.cmb_proveedores.Location = new System.Drawing.Point(65, 22);
            this.cmb_proveedores.Name = "cmb_proveedores";
            this.cmb_proveedores.Size = new System.Drawing.Size(639, 38);
            this.cmb_proveedores.TabIndex = 100040;
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
            // BajaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelSeleccionarCliente);
            this.Controls.Add(this.btn_desactivarProveedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BajaProveedores";
            this.Text = "BajaProveedores";
            this.panelSeleccionarCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_desactivarProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSeleccionarCliente;
        private System.Windows.Forms.ComboBox cmb_proveedores;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}