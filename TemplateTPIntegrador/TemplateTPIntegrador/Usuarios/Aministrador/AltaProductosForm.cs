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
            comboBox2.Items.Add("AUDIO");
            comboBox2.Items.Add("CELULARES");
            comboBox2.Items.Add("ELECTRO HOGAR");
            comboBox2.Items.Add("INFORMÁTICA");
            comboBox2.Items.Add("SMART TV");

            // Vincular el evento SelectedIndexChanged
           // comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void guna2NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_host_Click(object sender, EventArgs e)
        {

        }
    }
}
