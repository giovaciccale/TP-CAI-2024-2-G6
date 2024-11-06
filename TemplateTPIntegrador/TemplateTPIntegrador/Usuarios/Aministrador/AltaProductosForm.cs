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
using TemplateTPIntegrador.utils;
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

        private void cmbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();

        private void control_Enter(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                
                if (!originalColors.ContainsKey(control))
                {
                    originalColors[control] = control.BackColor;
                }
                control.BackColor = Color.White;
            }
        }

        private void control_Leave(object sender, EventArgs e)
        {
            if (sender is Control control && originalColors.ContainsKey(control))
            {
               
                control.BackColor = originalColors[control];
            }
        }

       
    }
}
