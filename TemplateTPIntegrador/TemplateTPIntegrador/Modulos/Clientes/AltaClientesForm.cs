﻿using Datos;
using Negocio.utils;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Modulos.Clientes
{
    public partial class AltaClientesForm : Form
    {
        public AltaClientesForm()
        {
            InitializeComponent();
        }

        private string HOST = "Grupo 6"; // Valor predeterminado para host
        private string CLIENTEID = "3220f419-a126-47a1-950f-202d19be8d4c";

        private void btn_crearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                var campos = new Dictionary<Control, (string nombreDelCampo, bool esNumerico, bool esFecha)>
        {
            { txt_nombre, ("Nombre", false, false) },
            { txt_apellido, ("Apellido", false, false) },
            { txt_email, ("Email", false, false) },
            { txt_fecha, ("Fecha De Nacimiento", false, true) },
            { txt_dni, ("DNI", true, false) },
            { txt_direccion, ("Dirección", false, false) },
            { txt_telefono, ("Teléfono", false, false) }
        };

                // Si la validación falla, detiene la ejecución
                if (!ValidadorDeCampos.ValidarCamposCliente(campos))
                {
                    return;
                }

                // Crear una instancia de ClienteWS con los datos del formulario
                ClienteWS cliente = new ClienteWS
                {
                    idUsuario = CLIENTEID,
                    nombre = txt_nombre.Text,
                    apellido = txt_apellido.Text,
                    dni = int.Parse(txt_dni.Text),
                    direccion = txt_direccion.Text,
                    telefono = txt_telefono.Text,
                    email = txt_email.Text,
                    fechaNacimiento = txt_fecha.Value,
                    host = HOST
                };

                // Instancia de ClientesWS para gestionar la creación
                ClientesWS clientesWS = new ClientesWS();

                // Intentar agregar el cliente
                bool resultado = clientesWS.Agregarcliente(cliente);

                if (resultado)
                {
                    MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // Llama al método para limpiar los campos
                }
                else
                {
                    MessageBox.Show("Error al agregar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarCampos()
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_dni.Clear();
            txt_direccion.Clear();
            txt_telefono.Clear();
            txt_email.Clear();
            txt_fecha.Value = DateTime.Now >= txt_fecha.MinDate && DateTime.Now <= txt_fecha.MaxDate ? DateTime.Now : txt_fecha.MinDate;

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            txt_nombre.BackColor = Color.White;
            panelNombre.BackColor = Color.White;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = Color.White;
            txt_apellido.BackColor = Color.White;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = Color.White;
            txt_email.BackColor = Color.White;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
        }

        private void txt_fecha_ValueChanged(object sender, EventArgs e)
        {
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = Color.White;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = Color.White;
            txt_dni.BackColor = Color.White;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = Color.White;
            txt_direccion.BackColor = Color.White;
            panelTelefono.BackColor = SystemColors.Control;
            txt_telefono.BackColor = SystemColors.Control;
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            txt_nombre.BackColor = SystemColors.Control;
            panelNombre.BackColor = SystemColors.Control;
            panelApellido.BackColor = SystemColors.Control;
            txt_apellido.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txt_email.BackColor = SystemColors.Control;
            panelFechaNacimiento.BackColor = SystemColors.Control;
            panelDni.BackColor = SystemColors.Control;
            txt_dni.BackColor = SystemColors.Control;
            panelDireccion.BackColor = SystemColors.Control;
            txt_direccion.BackColor = SystemColors.Control;
            panelTelefono.BackColor = Color.White;
            txt_telefono.BackColor = Color.White;
        }
    }
}
