namespace TemplateTPIntegrador.Modulos.Ventas
{
    partial class FacturaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPromociones = new System.Windows.Forms.Label();
            this.dgvPromociones = new System.Windows.Forms.DataGridView();
            this.colPromocion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbldni = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromociones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(18, 23);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(173, 20);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Nombre de la empresa:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(198, 18);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(448, 26);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.Text = "ElectroHogar";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(18, 63);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(154, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha de operación:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(198, 58);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(298, 26);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.Value = new System.DateTime(2024, 11, 15, 18, 34, 17, 0);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(18, 103);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(144, 20);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Nombre del cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(198, 98);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(448, 26);
            this.txtCliente.TabIndex = 3;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colDescripcion,
            this.colCantidad,
            this.colMontoUnitario,
            this.colMontoTotal});
            this.dgvDetalle.Location = new System.Drawing.Point(18, 138);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 62;
            this.dgvDetalle.Size = new System.Drawing.Size(1140, 308);
            this.dgvDetalle.TabIndex = 4;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "Id Producto";
            this.colIdProducto.MinimumWidth = 8;
            this.colIdProducto.Name = "colIdProducto";
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.MinimumWidth = 8;
            this.colDescripcion.Name = "colDescripcion";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 8;
            this.colCantidad.Name = "colCantidad";
            // 
            // colMontoUnitario
            // 
            this.colMontoUnitario.HeaderText = "Monto Unitario";
            this.colMontoUnitario.MinimumWidth = 8;
            this.colMontoUnitario.Name = "colMontoUnitario";
            // 
            // colMontoTotal
            // 
            this.colMontoTotal.HeaderText = "Monto Total";
            this.colMontoTotal.MinimumWidth = 8;
            this.colMontoTotal.Name = "colMontoTotal";
            // 
            // lblPromociones
            // 
            this.lblPromociones.AutoSize = true;
            this.lblPromociones.Location = new System.Drawing.Point(18, 462);
            this.lblPromociones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromociones.Name = "lblPromociones";
            this.lblPromociones.Size = new System.Drawing.Size(105, 20);
            this.lblPromociones.TabIndex = 5;
            this.lblPromociones.Text = "Promociones:";
            // 
            // dgvPromociones
            // 
            this.dgvPromociones.AllowUserToAddRows = false;
            this.dgvPromociones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromociones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPromocion,
            this.colDescuento});
            this.dgvPromociones.Location = new System.Drawing.Point(18, 492);
            this.dgvPromociones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPromociones.Name = "dgvPromociones";
            this.dgvPromociones.RowHeadersWidth = 62;
            this.dgvPromociones.Size = new System.Drawing.Size(1140, 154);
            this.dgvPromociones.TabIndex = 5;
            // 
            // colPromocion
            // 
            this.colPromocion.HeaderText = "Nombre Promoción";
            this.colPromocion.MinimumWidth = 8;
            this.colPromocion.Name = "colPromocion";
            // 
            // colDescuento
            // 
            this.colDescuento.HeaderText = "Monto Descuento";
            this.colDescuento.MinimumWidth = 8;
            this.colDescuento.Name = "colDescuento";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(858, 662);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(106, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total a pagar:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(978, 657);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(178, 26);
            this.txtTotal.TabIndex = 6;
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(668, 103);
            this.lbldni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(37, 20);
            this.lbldni.TabIndex = 7;
            this.lbldni.Text = "Dni:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(715, 97);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 662);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(256, 662);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 709);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.lblPromociones);
            this.Controls.Add(this.dgvPromociones);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FacturaForm";
            this.Text = "Comprobante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromociones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoTotal;
        private System.Windows.Forms.Label lblPromociones;
        private System.Windows.Forms.DataGridView dgvPromociones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromocion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }

}


