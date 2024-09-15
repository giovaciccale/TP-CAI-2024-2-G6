﻿using Datos;
using Negocio.utils;
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

namespace TemplateTPIntegrador
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            ValidacionesTemplateUtils validacionesTemplateUtils = new ValidacionesTemplateUtils();

<<<<<<< Updated upstream
            string usuario = txt_usuario.Text;
            string contraseña = txt_contraseña.Text;
=======
       
            // Validación de campos vacíos
            string mensaje_validacion_vacios = validacionesTemplateUtils.ValidarVacios(txt_usuario.Text, txt_contraseña.Text);
>>>>>>> Stashed changes

            validacionesTemplateUtils.ValidarStringVacio(usuario);
            validacionesTemplateUtils.ValidarStringVacio(contraseña);

<<<<<<< Updated upstream
            ValidacionesNegocioUtils validacionesNegocioUtils = new ValidacionesNegocioUtils();

            //LoginNegocio ln = new LoginNegocio();
            //ln.Login();
=======
                // Pone el cursor en el primer campo vacío
                if (mensaje_validacion_vacios.Contains("Usuario"))
                {
                    txt_usuario.Focus();
                }
                else if (mensaje_validacion_vacios.Contains("Contraseña"))
                {
                    txt_contraseña.Focus();
                }
                return;
            }
>>>>>>> Stashed changes
        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

<<<<<<< Updated upstream
=======
            // Se esconde el formulario padre (LogIn)
            this.Hide();

            // Se mantiene escondido el formulario padre mientras el formulario hijo (alta de usuarios) esté abierto.
            alta_usuarios.FormClosed += (s, args) => this.Show();

            // Se muestra el formulario hijo (alta de usuarios)
            alta_usuarios.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            Application.Exit();
        }

        private void txt_usuario_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "usuario" cuando lo clickea
            txt_usuario.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txt_contraseña.BackColor = SystemColors.Control;
        }

        private void txt_contraseña_Click(object sender, EventArgs e)
        {
            // Indica al usuario que está parado en el campo "Contraseña" cuando lo clickea
            txt_contraseña.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txt_usuario.BackColor = SystemColors.Control;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            // Permite al usuario ver la contraseña cuando clickea y mantiene sobre el ícono del campo "Contraseña"
            txt_contraseña.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            // Esconde la contraseña cuando el usuario suelta el click
            txt_contraseña.UseSystemPasswordChar = true;
>>>>>>> Stashed changes
        }
    }
}
