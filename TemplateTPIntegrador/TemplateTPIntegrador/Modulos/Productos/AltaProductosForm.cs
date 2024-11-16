using Datos;
using Guna.UI2.WinForms;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Usuarios.Aministrador
{
    public partial class AltaProductosForm : Form
    {
        public AltaProductosForm()
        {
            InitializeComponent();

            // Lista de categorías
            List<CategoriaWS> categorias = new List<CategoriaWS>
            {
                new CategoriaWS { Id = 1, Descripcion = "Audio" },
                new CategoriaWS { Id = 2, Descripcion = "Celulares" },
                new CategoriaWS { Id = 3, Descripcion = "Electro Hogar" },
                new CategoriaWS { Id = 4, Descripcion = "Informática" },
                new CategoriaWS { Id = 5, Descripcion = "Smart TV" }
            };

            // Cargar las categorías en el ComboBox
            cmbcategoria.DataSource = categorias;
            cmbcategoria.DisplayMember = "Descripcion"; // Muestra la descripción
            cmbcategoria.ValueMember = "Id"; // Asocia el Id como valor

            // Vincular el evento SelectedIndexChanged
            cmbcategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcategoria.SelectedItem != null)
            {
                // Obtén el ID de la categoría seleccionada
                int categoriaId = (int)cmbcategoria.SelectedValue;
                System.Diagnostics.Debug.WriteLine("ID de categoría seleccionada: " + categoriaId);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            nombre_txt.Clear();
            precio_in.Clear();
            stock_int.Value = 0; // Restablece la cantidad a 0
            cmbcategoria.SelectedIndex = -1; // Limpia la selección del ComboBox de categoría
        }

        private void btn_guardarproducto_Click_1(object sender, EventArgs e)
        {
            if (cmbcategoria.SelectedItem != null)
            {
                // Crear una instancia de ProductoWS con los datos del formulario
                ProductoWS producto = new ProductoWS
                {
                    idCategoria = (int)cmbcategoria.SelectedValue,
                    nombre = nombre_txt.Text,
                    precio = double.Parse(precio_in.Text),
                    stock = (int)stock_int.Value,
                    idUsuario = Guid.Parse("3220f419-a126-47a1-950f-202d19be8d4c"),  // ID del usuario que registra el producto
                    idProveedor = Guid.Parse("984c5534-0b26-46f1-8b89-04496bff9957"),  // ID del usuario que registra el producto
                };

                // Instancia de ProductosWS para gestionar la creación
                ProductosWS productosWS = new ProductosWS();

                // Intentar agregar el producto
                bool resultado = productosWS.AgregarProducto(producto);

                if (resultado)
                {
                    MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stock_int_ValueChanged(object sender, EventArgs e)
        {
            // Evento para manejar cambios en el valor de stock si se necesita
        }

        private void nombre_txt_TextChanged(object sender, EventArgs e)
        {
            panlNombreProducto.BackColor = Color.White;
            nombre_txt.BackColor = Color.White;
            cmbcategoria.BackColor = SystemColors.Control;
            panlCategoria.BackColor = SystemColors.Control;
            precio_in.BackColor = SystemColors.Control;
            pnlPrecio.BackColor = SystemColors.Control;
        }

        private void cmbcategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            panlNombreProducto.BackColor = SystemColors.Control;
            nombre_txt.BackColor = SystemColors.Control;
            cmbcategoria.BackColor = Color.White;
            panlCategoria.BackColor = Color.White;
            precio_in.BackColor = SystemColors.Control;
            pnlPrecio.BackColor = SystemColors.Control;
        }

        private void precio_in_TextChanged(object sender, EventArgs e)
        {
            panlNombreProducto.BackColor = SystemColors.Control;
            nombre_txt.BackColor = SystemColors.Control;
            cmbcategoria.BackColor = SystemColors.Control;
            panlCategoria.BackColor = SystemColors.Control;
            precio_in.BackColor = Color.White;
            pnlPrecio.BackColor = Color.White;
        }
    }
}
