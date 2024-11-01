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
    public partial class BajaProductosForm : Form
    {
        public BajaProductosForm()
        {
            InitializeComponent();
        }
      
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de mensaje para confirmar la eliminación
            var resultado = MessageBox.Show("¿Seguro que deseas eliminar el producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Lógica para eliminar el producto si el usuario confirma
            if (resultado == DialogResult.Yes)
            {
                // Aquí agregas la lógica para eliminar el producto
                MessageBox.Show("Producto eliminado", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mensaje opcional si se cancela la eliminación
                MessageBox.Show("Eliminación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
