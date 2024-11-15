namespace TemplateTPIntegrador.Modulos.Reportes
{
    partial class ReportesPorVendedorForm
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxVendedores = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_crearUsuario = new System.Windows.Forms.Button();
            this.TxtVentasPorVendedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxVendedores
            // 
            this.comboBoxVendedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxVendedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxVendedores.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboBoxVendedores.FormattingEnabled = true;
            this.comboBoxVendedores.Location = new System.Drawing.Point(472, 107);
            this.comboBoxVendedores.Name = "comboBoxVendedores";
            this.comboBoxVendedores.Size = new System.Drawing.Size(121, 29);
            this.comboBoxVendedores.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimePicker2.Location = new System.Drawing.Point(740, 109);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panel1.Location = new System.Drawing.Point(291, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 255);
            this.panel1.TabIndex = 3;
            // 
            // btn_crearUsuario
            // 
            this.btn_crearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_crearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_crearUsuario.Location = new System.Drawing.Point(436, 477);
            this.btn_crearUsuario.Name = "btn_crearUsuario";
            this.btn_crearUsuario.Size = new System.Drawing.Size(148, 35);
            this.btn_crearUsuario.TabIndex = 100011;
            this.btn_crearUsuario.Text = "Crear Reporte";
            this.btn_crearUsuario.UseVisualStyleBackColor = false;
            // 
            // TxtVentasPorVendedor
            // 
            this.TxtVentasPorVendedor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TxtVentasPorVendedor.Location = new System.Drawing.Point(150, 294);
            this.TxtVentasPorVendedor.Name = "TxtVentasPorVendedor";
            this.TxtVentasPorVendedor.Size = new System.Drawing.Size(100, 27);
            this.TxtVentasPorVendedor.TabIndex = 100012;
            // 
            // ReportesPorVendedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.TxtVentasPorVendedor);
            this.Controls.Add(this.btn_crearUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxVendedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesPorVendedorForm";
            this.Text = "ReportesPorVendedorForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVendedores;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_crearUsuario;
        private System.Windows.Forms.TextBox TxtVentasPorVendedor;
    }
}