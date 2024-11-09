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
            this.cmb_proveedores = new System.Windows.Forms.ComboBox();
            this.btn_desactivarProveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_proveedores
            // 
            this.cmb_proveedores.DropDownHeight = 500;
            this.cmb_proveedores.DropDownWidth = 500;
            this.cmb_proveedores.FormattingEnabled = true;
            this.cmb_proveedores.IntegralHeight = false;
            this.cmb_proveedores.Location = new System.Drawing.Point(59, 119);
            this.cmb_proveedores.Name = "cmb_proveedores";
            this.cmb_proveedores.Size = new System.Drawing.Size(459, 21);
            this.cmb_proveedores.TabIndex = 100034;
            // 
            // btn_desactivarProveedor
            // 
            this.btn_desactivarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_desactivarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_desactivarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desactivarProveedor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desactivarProveedor.ForeColor = System.Drawing.Color.White;
            this.btn_desactivarProveedor.Location = new System.Drawing.Point(404, 229);
            this.btn_desactivarProveedor.Name = "btn_desactivarProveedor";
            this.btn_desactivarProveedor.Size = new System.Drawing.Size(195, 35);
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
            this.label1.Location = new System.Drawing.Point(55, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 21);
            this.label1.TabIndex = 100032;
            this.label1.Text = "Elija Proveedor a Desactivar :";
            // 
            // BajaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_proveedores);
            this.Controls.Add(this.btn_desactivarProveedor);
            this.Controls.Add(this.label1);
            this.Name = "BajaProveedores";
            this.Text = "BajaProveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_proveedores;
        private System.Windows.Forms.Button btn_desactivarProveedor;
        private System.Windows.Forms.Label label1;
    }
}