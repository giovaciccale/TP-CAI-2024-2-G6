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
    public partial class ModificarUsuariosForm : Form
    {
        public ModificarUsuariosForm()
        {
            InitializeComponent();
        }

        private void txt_usuario_modificar_TextChanged(object sender, EventArgs e)
        {
            panelUsuarioModificar.BackColor = Color.White;
            txt_usuario_modificar.BackColor = Color.White;
            panelDireccionModificar.BackColor = SystemColors.Control;
            txt_direccion_modificar.BackColor = SystemColors.Control;
            panelTelefonoModificar.BackColor = SystemColors.Control;
            txt_telefono_modificar.BackColor = SystemColors.Control;
            panelEmailModificar.BackColor = SystemColors.Control;
            txt_email_modificar.BackColor= SystemColors.Control;
        }

        private void txt_direccion_modificar_TextChanged(object sender, EventArgs e)
        {
            panelUsuarioModificar.BackColor = SystemColors.Control;
            txt_usuario_modificar.BackColor = SystemColors.Control;
            panelDireccionModificar.BackColor = Color.White;
            txt_direccion_modificar.BackColor = Color.White;
            panelTelefonoModificar.BackColor = SystemColors.Control;
            txt_telefono_modificar.BackColor = SystemColors.Control;
            panelEmailModificar.BackColor = SystemColors.Control;
            txt_email_modificar.BackColor = SystemColors.Control;
        }

        private void txt_telefono_modificar_TextChanged(object sender, EventArgs e)
        {
            panelUsuarioModificar.BackColor = SystemColors.Control;
            txt_usuario_modificar.BackColor = SystemColors.Control;
            panelDireccionModificar.BackColor = SystemColors.Control;
            txt_direccion_modificar.BackColor = SystemColors.Control;
            panelTelefonoModificar.BackColor = Color.White;
            txt_telefono_modificar.BackColor = Color.White;
            panelEmailModificar.BackColor = SystemColors.Control;
            txt_email_modificar.BackColor = SystemColors.Control;
        }

        private void txt_email_modificar_TextChanged(object sender, EventArgs e)
        {
            panelUsuarioModificar.BackColor = SystemColors.Control;
            txt_usuario_modificar.BackColor = SystemColors.Control;
            panelDireccionModificar.BackColor = SystemColors.Control;
            txt_direccion_modificar.BackColor = SystemColors.Control;
            panelTelefonoModificar.BackColor = SystemColors.Control;
            txt_telefono_modificar.BackColor = SystemColors.Control;
            panelEmailModificar.BackColor = Color.White;
            txt_email_modificar.BackColor = Color.White;
        }
    }
}
