using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TemplateTPIntegrador.Usuarios.Aministrador
{
    public partial class AltaProductosForm : Form
    {
        public AltaProductosForm()
        {
            InitializeComponent();
            cmbcategoria.Items.Add("AUDIO");
            cmbcategoria.Items.Add("CELULARES");
            cmbcategoria.Items.Add("ELECTRO HOGAR");
            cmbcategoria.Items.Add("INFORMÁTICA");
            cmbcategoria.Items.Add("SMART TV");


            txtIdProducto.TabIndex = 2;
            cmbDescripcion.TabIndex = 0;
            cmbIdProveedor.TabIndex = 3;
            guna2NumericUpDown1.TabIndex = 4;
            cmbcategoria.TabIndex = 1;
            btn_guardarproducto.TabIndex = 5;
            btnlimpiar.TabIndex = 6;
        }

        private void btnLimpiar_Click(object sender, EventArgs e) 
        { 
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdProducto.Text = "";
            cmbDescripcion.Text = "";
            cmbIdProveedor.Text = "";
            guna2NumericUpDown1.Text = "";
            cmbcategoria.SelectedIndex = -1; 
        }


        private void guna2NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_host_Click(object sender, EventArgs e)
        {

        }
    }
}
