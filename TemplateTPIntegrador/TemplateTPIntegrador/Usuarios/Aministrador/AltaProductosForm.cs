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
            comboBox2.Items.Add("1 - AUDIO");
            comboBox2.Items.Add("2 - CELULARES");
            comboBox2.Items.Add("3 - ELECTRO HOGAR");
            comboBox2.Items.Add("4 - INFORMÁTICA");
            comboBox2.Items.Add("5 - SMART TV");

            // Vincular el evento SelectedIndexChanged
           // comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void guna2NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
