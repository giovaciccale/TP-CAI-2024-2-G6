using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Usuarios.Aministrador
{
    public partial class ModificarProductosForm : Form
    {
        public ModificarProductosForm()
        {
            InitializeComponent();
          

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de mensaje para confirmar la eliminación
            var resultado = MessageBox.Show("¿Seguro que deseas modificar el producto?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Lógica para eliminar el producto si el usuario confirma
            if (resultado == DialogResult.Yes)
            {
                // Aquí agregas la lógica para eliminar el producto
                MessageBox.Show("Producto modificado", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mensaje opcional si se cancela la eliminación
                MessageBox.Show("Modificación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
